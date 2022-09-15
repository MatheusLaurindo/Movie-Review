using MoviewReview.Core.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviewReview.Core.Domain.Entities
{
    public class Cast : Entity
    {
        public int TitleId { get; set; }
        public virtual Title Title { get; set; }
        public int ActorId { get; set; }
        public virtual Actor Actor { get; set; }
    }
}
