using MoviewReview.Core.Domain.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoviewReview.Core.Domain.Entities
{
    public class Review : Entity
    {
        public int Note { get; protected set; }
        public string Description { get; protected set; }
        public int UserId { get; set; }
        public virtual User Users { get; set; }
        public int TitleId { get; set; }
        public virtual Title Titles { get; set; }
    }
}
