using DomainNotificationSample.Data.Contexts;

namespace DomainNotificationSample.Data.Transaction
{
    public class UnitOfWork : IUnitOfWork
    {
        private DnDataContext _context;

        public UnitOfWork(DnDataContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Rollback()
        {
            //
        }
    }
}
