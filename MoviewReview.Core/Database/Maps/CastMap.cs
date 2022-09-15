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
    public class CastMap : BaseDomainMap<Cast>
    {
        public CastMap() : base("tbl_Cast")
        {
        }

        public override void Configure(EntityTypeBuilder<Cast> builder)
        {
            base.Configure(builder);
        }
    }
}
