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
    public class DirectorService : GenericService<Director>, IDirectorService
    {
        private readonly IDirectorRepository _repository;
        public DirectorService(IDirectorRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
