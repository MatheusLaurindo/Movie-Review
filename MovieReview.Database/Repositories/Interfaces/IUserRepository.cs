using MovieReview.Database.Repositories.Interfaces.Base;
using MovieReview.Core.Domain.Entities;

namespace MovieReview.Database.Repositories.Interfaces
{
    public interface IUserRepository : IGenericRepository<User>
    {
        Task<User> GetByNameAndPasswordAsync(string name, string password);
    }
}
