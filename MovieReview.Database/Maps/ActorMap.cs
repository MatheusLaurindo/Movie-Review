﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieReview.Core.Domain.Entities;
using MovieReview.Database.Maps.Base;

namespace MovieReview.Database.Maps
{
    public  class ActorMap : EntityMap<Actor>
    {
        public ActorMap() : base("Actors")
        {

        }

        public override void Configure(EntityTypeBuilder<Actor> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Name).HasColumnName("Name").HasMaxLength(100).IsRequired();
            builder.Property(x => x.BirthDate).HasColumnName("BirthDate").IsRequired();
        }
    }
}
