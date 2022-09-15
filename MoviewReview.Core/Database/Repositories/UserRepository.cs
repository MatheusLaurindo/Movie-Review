using Microsoft.EntityFrameworkCore;
using MoviewReview.Core.Database.Repositories.Base;
using MoviewReview.Core.Database.Repositories.Interfaces;
using MoviewReview.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviewReview.Core.Database.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository() : base()
        {
        }

        public async Task<User> GetByNameAndPasswordAsync(string name, string password)
        {
            return await _dbSet.Where(x => x.Name.Equals(name) && x.Password.Equals(password)).FirstOrDefaultAsync();
        }
    }
}
