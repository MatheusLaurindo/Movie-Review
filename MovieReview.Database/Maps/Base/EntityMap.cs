﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieReview.Core.Domain.Base;

namespace MovieReview.Database.Maps.Base
{
    public class EntityMap<T> : IEntityTypeConfiguration<T> where T : Entity
    {
        private readonly string _tableName;

        public EntityMap(string tableName = "")
        {
            _tableName = tableName;
        }

        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            if (!string.IsNullOrEmpty(_tableName))
            {
                builder.ToTable(_tableName);
            }

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("Id").ValueGeneratedOnAdd();
            builder.Property(x => x.CreationDate).HasColumnName("CreationDate").IsRequired();
        }
    }
}
