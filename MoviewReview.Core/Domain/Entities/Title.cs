using MoviewReview.Core.Domain.Base;
using MoviewReview.Core.Domain.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviewReview.Core.Domain.Entities
{
    public class Title : Entity
    {
        public TypeMovie TypeMovie { get; protected set; }
        public Genre Genre { get; protected set; }
        public string TitleMovie { get; protected set; }
        public string Director { get; protected set; }
        public string Screenwriter { get; protected set; }
        public string Cast { get; protected set; }
        public int Duration { get; protected set; }
    }
}
