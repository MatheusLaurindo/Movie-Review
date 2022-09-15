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
    public class ScreenwriterMap : EntityMap<Screenwriter>
    {
        public ScreenwriterMap() : base("tbl_Screenwriters")
        {

        }

        public override void Configure(EntityTypeBuilder<Screenwriter> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Name).HasColumnName("Name").HasMaxLength(100).IsRequired();
            builder.Property(x => x.BirthDate).HasColumnName("BirthDate").IsRequired();
        }
    }
}