﻿// <auto-generated />
using System;
using EfCoreMigrations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ef_core_migrations.Migrations
{
    [DbContext(typeof(BlogContext))]
    partial class BlogContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065");

            modelBuilder.Entity("EfCoreMigrations.Models.Blog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Author");

                    b.Property<string>("Description");

                    b.Property<int>("Rating");

                    b.Property<int>("Readers");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Blogs");

                    b.HasData(
                        new { Id = 1, Author = "Matjaž Mav", Rating = 0, Readers = 0, Title = ".NET Core is awesome!" }
                    );
                });

            modelBuilder.Entity("EfCoreMigrations.Models.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BlogId");

                    b.Property<string>("Content");

                    b.Property<DateTime?>("PublishedOn");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("BlogId");

                    b.ToTable("Posts");

                    b.HasData(
                        new { Id = 1, BlogId = 1, Content = "Teams? Huh?", Title = "EF Core Migrations?" },
                        new { Id = 2, BlogId = 1, Content = "Woow...", Title = "Generic REST controller?" }
                    );
                });

            modelBuilder.Entity("EfCoreMigrations.Models.Post", b =>
                {
                    b.HasOne("EfCoreMigrations.Models.Blog", "Blog")
                        .WithMany("Posts")
                        .HasForeignKey("BlogId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
