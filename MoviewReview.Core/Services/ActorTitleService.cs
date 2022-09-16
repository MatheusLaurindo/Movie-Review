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
    public class ActorTitleService : GenericService<ActorTitle>, IActorTitleService
    {
        public ActorTitleService(IGenericRepository<ActorTitle> repository) : base(repository)
        {
        }
    }
}
