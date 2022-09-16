using MoviewReview.Core.Database.Repositories.Base;
using MoviewReview.Core.Database.Repositories.Interfaces;
using MoviewReview.Core.Database.Repositories.Interfaces.Base;
using MoviewReview.Core.Domain.Entities;
using MoviewReview.Core.Services.Base;
using MoviewReview.Core.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviewReview.Core.Services
{
    public class UserService : GenericService<User>, IUserService
    {
        public UserService(IGenericRepository<User> repository) : base(repository)
        {
        }

        public Task<User> GetByNameAndPasswordAsync(string name, string password)
        {
            throw new NotImplementedException();
        }
    }
}
