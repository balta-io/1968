using DomainNotificationHelperCore;
using DomainNotificationSample.Domain.Commands;
using DomainNotificationSample.Domain.Entities;
using DomainNotificationSample.Domain.Repositories;
using DomainNotificationSample.Services.UserServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DomainNotificationSample.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Dado_um_username_invalido_deve_gerar_notificacao()
        {
            var runtime = new Runtime();

            RegisterUserCommand command = new RegisterUserCommand();
            command.Username = "";
            command.Password = "balt";

            RegisterUserService service = new RegisterUserService(command, new FakeUserRepository());
            service.Run();            

            runtime.AddNotifications(service.GetNotifications());

            Assert.IsTrue(runtime.HasNotifications());
        }

        [TestMethod]
        public void Dado_um_username_invalido_deve_gerar_notificacao2()
        {
            RegisterUserCommand command = new RegisterUserCommand();
            command.Username = "";
            command.Password = "balt";

            RegisterUserService service = new RegisterUserService(command, new FakeUserRepository());
            service.Run();

            Assert.IsTrue(service.HasNotifications());
        }
    }

    public class FakeUserRepository : IUserRepository
    {
        public void Save(User user)
        {
            return;
        }
    }
}
