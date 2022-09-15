using MoviewReview.Core.Domain.Base;
using MoviewReview.Core.Domain.Entities.Enums;

namespace MoviewReview.Core.Domain.Entities
{
    public class User : Entity
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public Rules Rules { get; set; }

        public virtual List<Review> Reviews { get; set; }
    }
}
