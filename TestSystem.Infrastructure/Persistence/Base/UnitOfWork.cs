using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using TestSystem.Core.Interfaces.Base;

namespace TestSystem.Infrastructure.Persistence.Base
{
    public class UnitOfWork<TContext> : IUnitOfWork<TContext> where TContext : DbContext, new()
    {
        private TContext _context;
        private IDbContextTransaction _transaction;
        private readonly IDbFactory<TContext> _dbFactory;

        public UnitOfWork(IDbFactory<TContext> dbFactory) => _dbFactory = dbFactory;

        public TContext Context
        {
            get { return _context ?? (_context = _dbFactory.Init()); }
        }

        public void Commit() => Context.SaveChanges();
        public async Task CommitAsync(CancellationToken cancellationToken = default) => await Context.SaveChangesAsync(cancellationToken);
        public async Task CommitAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default) => await Context.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);

        public void CreateTransaction() => _transaction = Context.Database.BeginTransaction();
        public async Task CreateTransactionAsync() => _transaction = await Context.Database.BeginTransactionAsync();
        public async Task CreateTransactionAsync(CancellationToken cancellationToken = default) => _transaction = await Context.Database.BeginTransactionAsync(cancellationToken);

        public void Rollback() { _transaction.Rollback(); _transaction.Dispose(); }
        public async Task RollbackAsync() { await _transaction.RollbackAsync(); await _transaction.DisposeAsync(); }
        public async Task RollbackAsync(CancellationToken cancellationToken = default) { await _transaction.RollbackAsync(cancellationToken); await _transaction.DisposeAsync(); }
    }
}
