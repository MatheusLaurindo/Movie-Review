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
    public class TitleMap : BaseDomainMap<Title>
    {
        public TitleMap() : base("tbl_Title")
        {
        }

        public override void Configure(EntityTypeBuilder<Title> builder)
        {
            base.Configure(builder);
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CreationDate);
            builder.Property(x => x.TitleMovie).HasColumnName("TitleMovie").HasMaxLength(50).IsRequired();
            builder.Property(x => x.TypeMovie).HasColumnName("TypeMovie").IsRequired();
        }
    }
}
