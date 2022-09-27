using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MoviewReview.Core.Database.Maps.Base;
using MoviewReview.Core.Domain.Entities;

namespace MoviewReview.Core.Database.Maps
{
    public class UserMap : EntityMap<User>
    {
        public UserMap() : base("tbl_Users")
        {
        }

        public override void Configure(EntityTypeBuilder<User> builder)
        {
            base.Configure(builder);
            
            builder.Property(x => x.Name).HasColumnName("Name").HasMaxLength(100).IsRequired();
            builder.Property(x => x.Password).HasColumnName("Password").HasMaxLength(100).IsRequired();
            builder.Property(x => x.Rules).HasColumnName("Rules").IsRequired();
        }
    }
}
