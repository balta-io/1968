using DomainNotificationHelperCore.Commands;

namespace DomainNotificationSample.Domain.Commands
{
    public class RegisterUserCommand : Command
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
