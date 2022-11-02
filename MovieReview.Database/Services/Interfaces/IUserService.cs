using MovieReview.Core.Domain.Entities;
using MovieReview.Database.Services.Interfaces.Base;

namespace MovieReview.Database.Services.Interfaces
{
    public interface IUserService : IGenericService<User>
    {
        Task<User> GetByNameAndPasswordAsync(string name, string password);
    }
}
