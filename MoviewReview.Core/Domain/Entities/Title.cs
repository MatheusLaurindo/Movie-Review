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
        public int DirectorId { get; set; }
        public virtual Director Director { get; protected set; }
        public string Screenwriter { get; protected set; }
        public Actor Actor { get; protected set; }
        public int Duration { get; protected set; }
        public string Description { get; set; }
        public List<Cast> Casts{ get; set; }
    }
}
