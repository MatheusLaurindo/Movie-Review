using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MoviewReview.Core.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviewReview.Core.Database.Maps.Base
{
    public class BaseDomainMap<T> : IEntityTypeConfiguration<T> where T : Entity
    {
        private readonly string _tableName;

        public BaseDomainMap(string tableName = "")
        {
            _tableName = tableName;
        }

        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            if (!string.IsNullOrEmpty(_tableName))
            {
                builder.ToTable(_tableName);
            }
        }
    }
}
