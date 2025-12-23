using SharedKernel.Domain;
using SharedKernel.Specification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedKernel.Repositoy
{
    public interface IReadRepository<T> where T : class,IDBEntity
    {
        Task<T?> GetByIdAsync<TKey>(TKey id, CancellationToken cancellationToken = default);

        Task<List<T>> GetListAsync(ISpecification<T>? specification = null, CancellationToken cancellationToken = default);

        Task<T?> GetSingleOrDefaultAsync(ISpecification<T>? specification = null, CancellationToken cancellationToken = default);

        Task<int> CountAsync(ISpecification<T>? specification = null, CancellationToken cancellationToken = default);

        Task<bool> AnyAsync(ISpecification<T>? specification = null, CancellationToken cancellationToken = default);
    }
}
