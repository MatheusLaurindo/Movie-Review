using MoviewReview.Core.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviewReview.Core.Domain.Entities
{
    public class ActorTitle : Entity
    {
        public int IdTitle { get; set; }
        public virtual Title Title { get; set; }
        public int IdActor { get; set; }
        public virtual Actor Actor { get; set; }
    }
}
