using MovieReview.Database.Repositories;
using MovieReview.Database.Repositories.Interfaces;
using MovieReview.Database.Repositories.Interfaces.Base;
using MovieReview.Core.Domain.Entities;
using MovieReview.Database.Services.Base;
using MovieReview.Database.Services.Interfaces;

namespace MovieReview.Database.Services
{
    public class ActorTitleService : GenericService<ActorTitle>, IActorTitleService
    {
        private readonly IActorTitleRepository _repository;
        public ActorTitleService(IActorTitleRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
