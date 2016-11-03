using DomainNotificationSample.Domain.Entities;
using System.Data.Entity;

namespace DomainNotificationSample.Data.Contexts
{
    public class DnDataContext : DbContext
    {
        public DnDataContext() : base("DnCnnStr") { }

        public DbSet<User> Users { get; set; }
    }
}
