using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MoviewReview.Core.Database.Maps.Base;
using MoviewReview.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviewReview.Core.Database.Maps
{
    public class ReviewMap : BaseDomainMap<Review>
    {
        public ReviewMap() : base("tbl_Review")
        {
        }

        public override void Configure(EntityTypeBuilder<Review> builder)
        {
            base.Configure(builder);
        }
    }
}
