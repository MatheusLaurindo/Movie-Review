using MoviewReview.Core.Domain.Base;
using MoviewReview.Core.Domain.Entities.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoviewReview.Core.Domain.Entities
{
    public class Title : Entity
    {
        public TypeMovie TypeMovie { get; protected set; }
        public Genre Genre { get; protected set; }
        public string TitleMovie { get; protected set; }
        public int IdDirector { get; set; }
        public virtual Director Director { get; protected set; }
        public int IdScreenwriter { get; set; }
        public Screenwriter Screenwriter { get; protected set; }        
        public int Duration { get; protected set; }
        public string Synopsis { get; set; }        
        public virtual List<Review> Reviews { get; set; }
        public virtual List<Actor> Actors { get; set; }

    }
}
