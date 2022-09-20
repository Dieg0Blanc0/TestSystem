using Ardalis.GuardClauses;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using TestSystem.Core.Exeption;
using TestSystem.Core.Interfaces.Base;
using TestSystem.Core.Interfaces.Services.Base;

namespace TestSystem.Infrastructure.Persistence.Service.Base
{
    public class ReadService<TGetDTO, TEntity, TRepo, TContext> : IReadService<TGetDTO, TEntity, TRepo, TContext>
        where TEntity : class
        where TRepo : IReadRepository<TEntity, TContext>
        where TContext : DbContext, new()
    {
        internal readonly IMapper _mapper;
        internal readonly TRepo _repository;
        internal readonly IUnitOfWork<TContext> _unitOfWork;

        protected IMapper Mapper => _mapper;
        protected TRepo Repository => _repository;
        protected IUnitOfWork<TContext> UnitOfWork => _unitOfWork;

        public ReadService(TRepo repository, IUnitOfWork<TContext> unitOfWork, IMapper mapper)
        {
            _repository = Guard.Against.Null(repository, nameof(repository));
            _unitOfWork = Guard.Against.Null(unitOfWork, nameof(unitOfWork));
            _mapper = Guard.Against.Null(mapper, nameof(mapper));
        }

        public async Task<IEnumerable<TGetDTO>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            var list = await _repository.GetAllAsync(cancellationToken);

            return _mapper.Map<IEnumerable<TGetDTO>>(list);
        }

        public async Task<TGetDTO> GetAsync(long id, CancellationToken cancellationToken = default)
        {
            var entity = await _repository.GetByIdAsync(id, cancellationToken);

            if (entity == null)
            {
                throw new EntityNotFoundException(typeof(TEntity), id);
            }

            return _mapper.Map<TGetDTO>(entity);
        }

        public async Task<IEnumerable<TGetDTO>> FilterAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default)
        {
            var list = await _repository.FilterAsync(predicate, cancellationToken);

            return _mapper.Map<IEnumerable<TGetDTO>>(list).ToList();
        }

        public async Task<TGetDTO> SingleFilterAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default)
        {
            var entity = await _repository.FilterSingleAsync(predicate, cancellationToken);

            return _mapper.Map<TGetDTO>(entity);
        }
    }
}
