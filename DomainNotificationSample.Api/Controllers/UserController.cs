using DomainNotificationSample.Data.Transaction;
using DomainNotificationSample.Domain.Commands;
using DomainNotificationSample.Domain.Repositories;
using DomainNotificationSample.Services.UserServices;
using Microsoft.AspNetCore.Mvc;

namespace DomainNotificationSample.Api.Controllers
{
    public class UserController : BaseController
    {
        private IUserRepository _repository;

        public UserController(IUnitOfWork uow, IUserRepository repository) : base(uow)
        {
            _repository = repository;
        }

        [HttpPost]
        [Route("api/v1/user")]
        public IActionResult RegisterUser([FromBody]RegisterUserCommand command)
        {
            RegisterUserService service = new RegisterUserService(command, _repository);
            service.Run();

            return ReturnResponse(service, new { message = "Usuário cadastrado com sucesso" }, null);
        }
    }
}