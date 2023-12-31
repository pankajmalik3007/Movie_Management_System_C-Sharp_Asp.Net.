﻿// <auto-generated />
using System;
using Infrastructure_Library.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure_Library.Migrations
{
    [DbContext(typeof(MainDbContext))]
    [Migration("20231225094317_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain_Library.Models.actor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("act_dob")
                        .HasColumnType("datetime2");

                    b.Property<string>("act_firstname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("act_gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("act_lastname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("actors");
                });

            modelBuilder.Entity("Domain_Library.Models.director", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("dir_dob")
                        .HasColumnType("datetime2");

                    b.Property<string>("dir_firstname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dir_lastname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("directors");
                });

            modelBuilder.Entity("Domain_Library.Models.genres", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("gen_title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("genres");
                });

            modelBuilder.Entity("Domain_Library.Models.movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("mov_dt_rel")
                        .HasColumnType("datetime2");

                    b.Property<string>("mov_language")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mov_rel_country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mov_time")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mov_title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mov_year")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float?>("num_of_rating")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("movie");
                });

            modelBuilder.Entity("Domain_Library.Models.movie_cast", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("act_id")
                        .HasColumnType("int");

                    b.Property<int>("mov_id")
                        .HasColumnType("int");

                    b.Property<string>("role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("act_id");

                    b.HasIndex("mov_id");

                    b.ToTable("movie_cast");
                });

            modelBuilder.Entity("Domain_Library.Models.movie_direction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("dir_id")
                        .HasColumnType("int");

                    b.Property<int>("mov_id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("dir_id");

                    b.HasIndex("mov_id");

                    b.ToTable("movie_direction");
                });

            modelBuilder.Entity("Domain_Library.Models.movie_genres", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("gen_id")
                        .HasColumnType("int");

                    b.Property<int>("mov_id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("gen_id");

                    b.HasIndex("mov_id");

                    b.ToTable("movie_genres");
                });

            modelBuilder.Entity("Domain_Library.Models.rating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("mov_id")
                        .HasColumnType("int");

                    b.Property<int>("rev_id")
                        .HasColumnType("int");

                    b.Property<int>("rev_stars")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("mov_id");

                    b.HasIndex("rev_id");

                    b.ToTable("rating");
                });

            modelBuilder.Entity("Domain_Library.Models.reviewer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("rev_address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("rev_city")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("rev_country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("rev_dob")
                        .HasColumnType("datetime2");

                    b.Property<string>("rev_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("rev_phone_no")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("rev_pincode")
                        .HasColumnType("int");

                    b.Property<string>("rev_state")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("reviewer");
                });

            modelBuilder.Entity("Domain_Library.Models.movie_cast", b =>
                {
                    b.HasOne("Domain_Library.Models.actor", "actor")
                        .WithMany("movie_cast")
                        .HasForeignKey("act_id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Domain_Library.Models.movie", "movie")
                        .WithMany("mov_casts")
                        .HasForeignKey("mov_id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("actor");

                    b.Navigation("movie");
                });

            modelBuilder.Entity("Domain_Library.Models.movie_direction", b =>
                {
                    b.HasOne("Domain_Library.Models.director", "director")
                        .WithMany("movie_directions")
                        .HasForeignKey("dir_id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Domain_Library.Models.movie", "movie")
                        .WithMany("mov_directions")
                        .HasForeignKey("mov_id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("director");

                    b.Navigation("movie");
                });

            modelBuilder.Entity("Domain_Library.Models.movie_genres", b =>
                {
                    b.HasOne("Domain_Library.Models.genres", "genres")
                        .WithMany("Movie_Genres")
                        .HasForeignKey("gen_id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Domain_Library.Models.movie", "movie")
                        .WithMany("mov_genres")
                        .HasForeignKey("mov_id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("genres");

                    b.Navigation("movie");
                });

            modelBuilder.Entity("Domain_Library.Models.rating", b =>
                {
                    b.HasOne("Domain_Library.Models.movie", "movie")
                        .WithMany("mov_rating")
                        .HasForeignKey("mov_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain_Library.Models.reviewer", "reviewer")
                        .WithMany("rating")
                        .HasForeignKey("rev_id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("movie");

                    b.Navigation("reviewer");
                });

            modelBuilder.Entity("Domain_Library.Models.actor", b =>
                {
                    b.Navigation("movie_cast");
                });

            modelBuilder.Entity("Domain_Library.Models.director", b =>
                {
                    b.Navigation("movie_directions");
                });

            modelBuilder.Entity("Domain_Library.Models.genres", b =>
                {
                    b.Navigation("Movie_Genres");
                });

            modelBuilder.Entity("Domain_Library.Models.movie", b =>
                {
                    b.Navigation("mov_casts");

                    b.Navigation("mov_directions");

                    b.Navigation("mov_genres");

                    b.Navigation("mov_rating");
                });

            modelBuilder.Entity("Domain_Library.Models.reviewer", b =>
                {
                    b.Navigation("rating");
                });
#pragma warning restore 612, 618
        }
    }
}
