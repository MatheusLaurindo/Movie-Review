﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MoviewReview.Core.Database;

#nullable disable

namespace MoviewReview.Core.Migrations
{
    [DbContext(typeof(MoviewReviewContext))]
    [Migration("20220915020900_AddRelationMN")]
    partial class AddRelationMN
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MoviewReview.Core.Domain.Entities.Actor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TitleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TitleId");

                    b.ToTable("Actors");
                });

            modelBuilder.Entity("MoviewReview.Core.Domain.Entities.Cast", b =>
                {
                    b.Property<int>("IdCast")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCast"), 1L, 1);

                    b.Property<int>("ActorId")
                        .HasColumnType("int");

                    b.Property<int>("TitleId")
                        .HasColumnType("int");

                    b.HasKey("IdCast");

                    b.HasIndex("ActorId");

                    b.HasIndex("TitleId");

                    b.ToTable("Casts");
                });

            modelBuilder.Entity("MoviewReview.Core.Domain.Entities.Director", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Directors");
                });

            modelBuilder.Entity("MoviewReview.Core.Domain.Entities.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Note")
                        .HasColumnType("int");

                    b.Property<int>("TitleId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TitleId");

                    b.HasIndex("UserId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("MoviewReview.Core.Domain.Entities.Title", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DirectorId")
                        .HasColumnType("int");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<int>("Genre")
                        .HasColumnType("int");

                    b.Property<string>("Screenwriter")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TitleMovie")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TypeMovie")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DirectorId");

                    b.ToTable("Titles");
                });

            modelBuilder.Entity("MoviewReview.Core.Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rules")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MoviewReview.Core.Domain.Entities.Actor", b =>
                {
                    b.HasOne("MoviewReview.Core.Domain.Entities.Title", null)
                        .WithMany("Cast")
                        .HasForeignKey("TitleId");
                });

            modelBuilder.Entity("MoviewReview.Core.Domain.Entities.Cast", b =>
                {
                    b.HasOne("MoviewReview.Core.Domain.Entities.Actor", "Actor")
                        .WithMany("Casts")
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MoviewReview.Core.Domain.Entities.Title", "Title")
                        .WithMany()
                        .HasForeignKey("TitleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Actor");

                    b.Navigation("Title");
                });

            modelBuilder.Entity("MoviewReview.Core.Domain.Entities.Review", b =>
                {
                    b.HasOne("MoviewReview.Core.Domain.Entities.Title", "Titles")
                        .WithMany()
                        .HasForeignKey("TitleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MoviewReview.Core.Domain.Entities.User", "Users")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Titles");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("MoviewReview.Core.Domain.Entities.Title", b =>
                {
                    b.HasOne("MoviewReview.Core.Domain.Entities.Director", "Director")
                        .WithMany()
                        .HasForeignKey("DirectorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Director");
                });

            modelBuilder.Entity("MoviewReview.Core.Domain.Entities.Actor", b =>
                {
                    b.Navigation("Casts");
                });

            modelBuilder.Entity("MoviewReview.Core.Domain.Entities.Title", b =>
                {
                    b.Navigation("Cast");
                });
#pragma warning restore 612, 618
        }
    }
}
