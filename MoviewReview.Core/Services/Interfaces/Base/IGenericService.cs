using MoviewReview.Core.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviewReview.Core.Services.Interfaces.Base
{
    public interface IGenericService<T> : IDisposable where T : Entity
    {
        Task AddAsync(T obj);
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task UpdateAsync(T obj);
        Task RemoveAsync(T obj);
        Task DeleteByIdAsync(string id);
    }
}
