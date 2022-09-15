using MoviewReview.Core.Database.Repositories.Base;
using MoviewReview.Core.Database.Repositories.Interfaces;
using MoviewReview.Core.Domain.Entities;

namespace MoviewReview.Core.Database.Repositories
{
    public class ReviewRepository : GenericRepository<Review>, IReviewRepository
    {
    }
}
