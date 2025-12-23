using SharedKernel.Domain;
using SharedKernel.Specification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedKernel.Repositoy
{
    public interface  IRepository<T> : IReadRepository<T>  where T : class, IDBEntity, IAggregateRoot
    {
        T Add(T entity);

        void Update(T entity);

        void Delete(T entity);

        Task<int> BatchDeleteAsync(ISpecification<T>? specification = null, CancellationToken cancellationToken = default);

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
