using DomainNotificationHelperCore.Commands;
using DomainNotificationSample.Data.Transaction;
using Microsoft.AspNetCore.Mvc;

namespace DomainNotificationSample.Api.Controllers
{
    public class BaseController : Controller
    {
        private IUnitOfWork _uow;

        public BaseController(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public IActionResult ReturnResponse(ServerCommand service, object success, object error)
        {
            if (service.HasNotifications())
                return BadRequest(new {
                    success = false,
                    data = error,
                    errors = service.GetNotifications()
                });

            _uow.Commit();
            return Ok(new { success = true, data = success });
        }
    }
}
