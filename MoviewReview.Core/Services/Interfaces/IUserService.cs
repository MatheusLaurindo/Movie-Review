using MoviewReview.Core.Domain.Entities;
using MoviewReview.Core.Services.Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviewReview.Core.Services.Interfaces
{
    public interface IUserService : IGenericService<User>
    {
        Task<User> GetByNameAndPasswordAsync(string name, string password);
    }
}
