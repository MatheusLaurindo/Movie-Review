using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MoviewReview.Core.Database.Maps.Base;
using MoviewReview.Core.Domain.Entities;

namespace MoviewReview.Core.Database.Maps
{
    public class UserMap : BaseDomainMap<User>
    {
        public UserMap() : base("tbl_User")
        {
        }

        public override void Configure(EntityTypeBuilder<User> builder)
        {
            base.Configure(builder);
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CreationDate);
            builder.Property(x => x.Name).HasColumnName("Name").HasMaxLength(50).IsRequired();
            builder.Property(x => x.Password).HasColumnName("Password").HasMaxLength(100).IsRequired();
        }
    }
}
