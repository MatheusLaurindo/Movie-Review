using MoviewReview.Core.Database.Repositories.Interfaces.Base;
using MoviewReview.Core.Domain.Entities;

namespace MoviewReview.Core.Database.Repositories.Interfaces
{
    public interface IUserRepository : IGenericRepository<User>
    {
        Task<User> GetByNameAndPasswordAsync(string name, string password);
    }
}
