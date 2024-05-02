﻿// <auto-generated />
using System;
using EfCodeFirst.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EfCodeFirst.DataAccess.Migrations
{
    [DbContext(typeof(MoviesContext))]
    partial class MoviesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EfCodeFirst.DataAccess.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("department_id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)")
                        .HasColumnName("department_name");

                    b.HasKey("Id");

                    b.ToTable("Department");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Camera"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Directing"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Production"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Writing"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Editing"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Sound"
                        });
                });

            modelBuilder.Entity("EfCodeFirst.DataAccess.Models.Gender", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("gender_id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("gender");

                    b.HasKey("Id");

                    b.ToTable("Gender");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Female"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Male"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Unspecified"
                        });
                });

            modelBuilder.Entity("EfCodeFirst.DataAccess.Models.Language", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("language_id");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("language_code");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasColumnName("language_name");

                    b.HasKey("Id");

                    b.ToTable("Language");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Code = "en",
                            Name = "English"
                        },
                        new
                        {
                            Id = 2,
                            Code = "es",
                            Name = "Spanish"
                        },
                        new
                        {
                            Id = 3,
                            Code = "de",
                            Name = "German"
                        },
                        new
                        {
                            Id = 4,
                            Code = "it",
                            Name = "Italian"
                        },
                        new
                        {
                            Id = 5,
                            Code = "ja",
                            Name = "Japanese"
                        },
                        new
                        {
                            Id = 6,
                            Code = "hi",
                            Name = "Hindi"
                        });
                });

            modelBuilder.Entity("EfCodeFirst.DataAccess.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("movie_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<long?>("Budget")
                        .HasColumnType("bigint")
                        .HasColumnName("budget");

                    b.Property<DateTime?>("ReleaseDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("release_date");

                    b.Property<long?>("Revenue")
                        .HasColumnType("bigint")
                        .HasColumnName("revenue");

                    b.Property<int?>("Runtime")
                        .HasColumnType("int")
                        .HasColumnName("runtime");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("title");

                    b.Property<decimal?>("VotesAvg")
                        .HasColumnType("decimal(5,3)")
                        .HasColumnName("votes_avg");

                    b.Property<int?>("VotesCount")
                        .HasColumnType("int")
                        .HasColumnName("votes_count");

                    b.HasKey("Id");

                    b.ToTable("Movie");
                });

            modelBuilder.Entity("EfCodeFirst.DataAccess.Models.MovieCast", b =>
                {
                    b.Property<int>("MovieId")
                        .HasColumnType("int")
                        .HasColumnName("movie_id");

                    b.Property<int>("PersonId")
                        .HasColumnType("int")
                        .HasColumnName("person_id");

                    b.Property<int?>("CastOrder")
                        .HasColumnType("int")
                        .HasColumnName("cast_order");

                    b.Property<string>("CharacterName")
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)")
                        .HasColumnName("character_name");

                    b.HasKey("MovieId", "PersonId");

                    b.HasIndex("PersonId");

                    b.ToTable("Movie_Cast");
                });

            modelBuilder.Entity("EfCodeFirst.DataAccess.Models.MovieCrew", b =>
                {
                    b.Property<int>("MovieId")
                        .HasColumnType("int")
                        .HasColumnName("movie_id");

                    b.Property<int>("PersonId")
                        .HasColumnType("int")
                        .HasColumnName("person_id");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int")
                        .HasColumnName("department_id");

                    b.Property<string>("Job")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)")
                        .HasColumnName("job");

                    b.HasKey("MovieId", "PersonId", "DepartmentId");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("PersonId");

                    b.ToTable("Movie_Crew");
                });

            modelBuilder.Entity("EfCodeFirst.DataAccess.Models.MovieLanguages", b =>
                {
                    b.Property<int>("MovieId")
                        .HasColumnType("int")
                        .HasColumnName("movie_id");

                    b.Property<int>("LanguageId")
                        .HasColumnType("int")
                        .HasColumnName("language_id");

                    b.HasKey("MovieId", "LanguageId");

                    b.HasIndex("LanguageId");

                    b.ToTable("Movie_Languages");
                });

            modelBuilder.Entity("EfCodeFirst.DataAccess.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("person_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("GenderId")
                        .HasColumnType("int")
                        .HasColumnName("gender_id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasColumnName("person_name");

                    b.HasKey("Id");

                    b.HasIndex("GenderId");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("EfCodeFirst.DataAccess.Models.MovieCast", b =>
                {
                    b.HasOne("EfCodeFirst.DataAccess.Models.Movie", "Movie")
                        .WithMany("MovieCasts")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EfCodeFirst.DataAccess.Models.Person", "Person")
                        .WithMany("MovieCasts")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("EfCodeFirst.DataAccess.Models.MovieCrew", b =>
                {
                    b.HasOne("EfCodeFirst.DataAccess.Models.Department", "Department")
                        .WithMany("MovieCrews")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EfCodeFirst.DataAccess.Models.Movie", "Movie")
                        .WithMany("MovieCrews")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EfCodeFirst.DataAccess.Models.Person", "Person")
                        .WithMany("MovieCrews")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");

                    b.Navigation("Movie");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("EfCodeFirst.DataAccess.Models.MovieLanguages", b =>
                {
                    b.HasOne("EfCodeFirst.DataAccess.Models.Language", "Language")
                        .WithMany("MovieLanguages")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EfCodeFirst.DataAccess.Models.Movie", "Movie")
                        .WithMany("MovieLanguages")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Language");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("EfCodeFirst.DataAccess.Models.Person", b =>
                {
                    b.HasOne("EfCodeFirst.DataAccess.Models.Gender", "Gender")
                        .WithMany("Persons")
                        .HasForeignKey("GenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Gender");
                });

            modelBuilder.Entity("EfCodeFirst.DataAccess.Models.Department", b =>
                {
                    b.Navigation("MovieCrews");
                });

            modelBuilder.Entity("EfCodeFirst.DataAccess.Models.Gender", b =>
                {
                    b.Navigation("Persons");
                });

            modelBuilder.Entity("EfCodeFirst.DataAccess.Models.Language", b =>
                {
                    b.Navigation("MovieLanguages");
                });

            modelBuilder.Entity("EfCodeFirst.DataAccess.Models.Movie", b =>
                {
                    b.Navigation("MovieCasts");

                    b.Navigation("MovieCrews");

                    b.Navigation("MovieLanguages");
                });

            modelBuilder.Entity("EfCodeFirst.DataAccess.Models.Person", b =>
                {
                    b.Navigation("MovieCasts");

                    b.Navigation("MovieCrews");
                });
#pragma warning restore 612, 618
        }
    }
}
