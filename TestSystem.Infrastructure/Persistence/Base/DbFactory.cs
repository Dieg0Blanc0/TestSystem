using Microsoft.EntityFrameworkCore;
using TestSystem.Core.Interfaces.Base;

namespace TestSystem.Infrastructure.Persistence.Base
{
    public class DbFactory<TContext> : IDisposable, IDbFactory<TContext> where TContext : DbContext, new()
    {
        private bool _disposed;
        private TContext _context;
        private Func<TContext> _factory;

        public DbFactory(Func<TContext> dbContextFactory) => _factory = dbContextFactory;

        public void Dispose()
        {
            if (!_disposed && _context != null)
            {
                _disposed = true;
                _context.Dispose();
                GC.SuppressFinalize(this);
            }
        }

        public TContext Init() => _context ??= _factory.Invoke();
    }
}
