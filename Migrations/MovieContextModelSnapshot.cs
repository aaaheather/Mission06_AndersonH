﻿// <auto-generated />
using System;
using BaconsaleMovies.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BaconsaleMovies.Migrations
{
    [DbContext(typeof(MovieContext))]
    partial class MovieContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.2");

            modelBuilder.Entity("BaconsaleMovies.Models.Movie", b =>
                {
                    b.Property<int>("movie_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("directors")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("edited")
                        .HasColumnType("TEXT");

                    b.Property<bool?>("lent_to")
                        .HasColumnType("INTEGER");

                    b.Property<string>("notes")
                        .HasColumnType("TEXT");

                    b.Property<string>("rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("subcategory")
                        .HasColumnType("TEXT");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("year")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("movie_id");

                    b.ToTable("Movies");
                });
#pragma warning restore 612, 618
        }
    }
}