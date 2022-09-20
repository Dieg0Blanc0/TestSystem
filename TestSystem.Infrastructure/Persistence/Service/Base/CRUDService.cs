using Ardalis.GuardClauses;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TestSystem.Core.Exeption;
using TestSystem.Core.Interfaces.Base;
using TestSystem.Core.Interfaces.Services.Base;

namespace TestSystem.Infrastructure.Persistence.Service.Base
{
    public class CRUDService<TGetDTO, TAddDTO, TUpdateDTO, TDeleteDTO, TEntity, TRepo, TContext> : ICrudService<TGetDTO, TAddDTO, TUpdateDTO, TDeleteDTO, TEntity, TRepo, TContext>
        where TEntity : class
        where TRepo : IBaseRepository<TEntity, TContext>
        where TContext : DbContext, new()
    {
        internal readonly IMapper _mapper;
        internal readonly TRepo _repository;
        internal readonly IUnitOfWork<TContext> _unitOfWork;

        protected IMapper Mapper => _mapper;
        protected TRepo Repository => _repository;
        protected IUnitOfWork<TContext> UnitOfWork => _unitOfWork;

        public CRUDService(TRepo repository, IUnitOfWork<TContext> unitOfWork, IMapper mapper)
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

        public async Task<TAddDTO> InsertAsync(TAddDTO dto, CancellationToken cancellationToken = default)
        {
            var newEntity = _mapper.Map<TEntity>(dto);

            await _repository.AddAsync(newEntity, cancellationToken);
            await _unitOfWork.CommitAsync(cancellationToken);

            return _mapper.Map<TAddDTO>(newEntity);
        }

        public async Task<TUpdateDTO> UpdateAsync(TUpdateDTO dto, CancellationToken cancellationToken = default)
        {
            var entityToUpdate = _mapper.Map<TEntity>(dto);

            _repository.Update(entityToUpdate);
            await _unitOfWork.CommitAsync(cancellationToken);

            return _mapper.Map<TUpdateDTO>(entityToUpdate);
        }

        public async Task<TDeleteDTO> DEleteAsync(TDeleteDTO dto, CancellationToken cancellationToken = default)
        {
            var deleteEntity = await _repository.GetByIdAsync(Convert.ToInt32(Mapper.Map<TEntity>(dto)), cancellationToken);

            if (deleteEntity == null)
            {
                throw new EntityNotFoundException(typeof(TEntity), Convert.ToInt32(Mapper.Map<TEntity>(dto)));
            }

            _repository.Delete(deleteEntity);
            await _unitOfWork.CommitAsync(cancellationToken);

            return Mapper.Map<TDeleteDTO>(deleteEntity);
        }
    }
}
