using DomainNotificationSample.Data.Contexts;
using DomainNotificationSample.Domain.Entities;
using DomainNotificationSample.Domain.Repositories;

namespace DomainNotificationSample.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private DnDataContext _context;

        public UserRepository(DnDataContext context)
        {
            _context = context;
        }

        public void Save(User user)
        {
            _context.Users.Add(user);
        }
    }
}
