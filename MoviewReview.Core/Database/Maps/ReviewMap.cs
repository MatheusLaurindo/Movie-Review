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
    public class ReviewMap : EntityMap<Review>
    {
        public ReviewMap() : base("tbl_Reviews")
        {
        }

        public override void Configure(EntityTypeBuilder<Review> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Note).HasColumnName("Note").IsRequired();
            builder.Property(x => x.Description).HasColumnName("Description").HasMaxLength(int.MaxValue).IsRequired();
            builder.Property(x => x.IdUser).HasColumnName("IdUser").IsRequired();
            builder.Property(x => x.IdTitle).HasColumnName("IdTitle").IsRequired();

            builder.HasOne(x => x.User).WithMany(x => x.Reviews).HasForeignKey(x => x.IdUser);
            builder.HasOne(x => x.Title).WithMany(x => x.Reviews).HasForeignKey(x => x.IdTitle);
            
        }
    }
}
