using MoviewReview.Core.Domain.Base;
using System.Linq.Expressions;

namespace MoviewReview.Core.Database.Repositories.Interfaces.Base
{
    public interface IGenericRepository<T> : IDisposable where T : Entity
    {
        Task AddAsync(T obj);
        Task<T> GetByIdAsync(int id);
        Task<List<T>> GetAllAsync();
        Task UpdateAsync(T obj);
        Task RemoveAsync(T obj);
        Task RemoveByIdAsync(int id);
        Task<IEnumerable<T>> SearchAsync(Expression<Func<T, bool>> predicate);
    }
}
