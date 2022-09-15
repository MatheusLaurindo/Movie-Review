using Microsoft.EntityFrameworkCore;
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
    public  class DirectorMap : EntityMap<Director>
    {
        public DirectorMap() : base("tbl_Directors")
        {

        }

        public override void Configure(EntityTypeBuilder<Director> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Name).HasColumnName("Name").HasMaxLength(100).IsRequired();
            builder.Property(x => x.BirthDate).HasColumnName("BirthDate").IsRequired();
        }
    }
}
