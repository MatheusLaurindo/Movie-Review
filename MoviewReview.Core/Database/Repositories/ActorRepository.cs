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
    public class ActorRepository : GenericRepository<Actor>, IActorRepository
    {
    }
}
