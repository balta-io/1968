using DomainNotificationSample.Domain.Entities;

namespace DomainNotificationSample.Domain.Repositories
{
    public interface IUserRepository
    {
        void Save(User user);
    }
}
