using MoviewReview.Core.Database.Repositories.Interfaces.Base;
using MoviewReview.Core.Domain.Base;
using MoviewReview.Core.Domain.Entities;
using MoviewReview.Core.Services.Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviewReview.Core.Services.Base
{
    public class GenericService<T> : IGenericService<T> where T : Entity
    {
        private readonly IGenericRepository<T> _repository;
        private IGenericRepository<Review> repository;

        public GenericService(IGenericRepository<T> repository)
        {
            _repository = repository;
        }

        public GenericService(IGenericRepository<Review> repository)
        {
            this.repository = repository;
        }

        public async Task AddAsync(T obj)
        {
            await _repository.AddAsync(obj);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task UpdateAsync(T obj)
        {
            await _repository.UpdateAsync(obj);
        }

        public async Task RemoveAsync(T obj)
        {
            await _repository.RemoveAsync(obj);
        }

        public async Task DeleteByIdAsync(string id)
        {
            await _repository.RemoveByIdAsync(id);
        }

        public void Dispose()
        {
            _repository.Dispose();
        }
    }
}
