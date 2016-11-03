using DomainNotificationHelperCore.Assertions;
using DomainNotificationHelperCore.Commands;
using DomainNotificationSample.Domain.Commands;
using DomainNotificationSample.Domain.Entities;
using DomainNotificationSample.Domain.Repositories;

namespace DomainNotificationSample.Services.UserServices
{
    public class RegisterUserService : ServerCommand
    {
        private RegisterUserCommand _command;
        private IUserRepository _repository;

        public RegisterUserService(RegisterUserCommand command, 
            IUserRepository repository) : base(command)
        {
            _command = command;
            _repository = repository;            
        }

        public void Run()
        {
            Validate();
            if (HasNotifications())
                return;

            // Segue o Fluxo
            var user = new User(_command.Username, _command.Password);
            _repository.Save(user);
        }

        public void Validate()
        {
            AddNotification(Assert.Length(_command.Username, 5, 20, "Username", "Usuário inválido"));
        }
    }
}
