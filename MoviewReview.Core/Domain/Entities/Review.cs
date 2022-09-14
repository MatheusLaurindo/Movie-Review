using MoviewReview.Core.Domain.Base;

namespace MoviewReview.Core.Domain.Entities
{
    public class Review : Entity
    {
        public int Note { get; protected set; }
        public string Description { get; protected set; }
    }
}
