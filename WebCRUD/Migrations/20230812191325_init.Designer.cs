﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebCRUD.DAL;

#nullable disable

namespace WebCRUD.Migrations
{
    [DbContext(typeof(FilmDBContext))]
    [Migration("20230812191325_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WebCRUD.Models.Actor", b =>
                {
                    b.Property<int>("ActorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ActorID"), 1L, 1);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ActorID");

                    b.ToTable("Actor");

                    b.HasData(
                        new
                        {
                            ActorID = 1,
                            FirstName = "Cem",
                            LastName = "YILMAZ"
                        },
                        new
                        {
                            ActorID = 2,
                            FirstName = "Özkan",
                            LastName = "UĞUR"
                        },
                        new
                        {
                            ActorID = 3,
                            FirstName = "Matt",
                            LastName = "Damon"
                        });
                });

            modelBuilder.Entity("WebCRUD.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryID"), 1L, 1);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.HasKey("CategoryID");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            CategoryID = 1,
                            CategoryName = "Drama"
                        },
                        new
                        {
                            CategoryID = 2,
                            CategoryName = "Action"
                        },
                        new
                        {
                            CategoryID = 3,
                            CategoryName = "Biography"
                        });
                });

            modelBuilder.Entity("WebCRUD.Models.Film", b =>
                {
                    b.Property<int>("FilmID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FilmID"), 1L, 1);

                    b.Property<int?>("CategoryID")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<string>("FilmName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FilmID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Films");

                    b.HasData(
                        new
                        {
                            FilmID = 1,
                            CategoryID = 1,
                            Description = "Bir Uzay Filmi",
                            Duration = 109,
                            FilmName = "G.O.R.A."
                        },
                        new
                        {
                            FilmID = 2,
                            CategoryID = 2,
                            Description = "Uzay Filmi",
                            Duration = 109,
                            FilmName = "Installer"
                        });
                });

            modelBuilder.Entity("WebCRUD.Models.FilmActor", b =>
                {
                    b.Property<int>("FAID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FAID"), 1L, 1);

                    b.Property<int>("ActorID")
                        .HasColumnType("int");

                    b.Property<string>("ActorRole")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FilmID")
                        .HasColumnType("int");

                    b.HasKey("FAID");

                    b.HasIndex("ActorID");

                    b.HasIndex("FilmID");

                    b.ToTable("FilmActor", (string)null);

                    b.HasData(
                        new
                        {
                            FAID = 1,
                            ActorID = 1,
                            ActorRole = "Arif Işık",
                            FilmID = 1
                        },
                        new
                        {
                            FAID = 2,
                            ActorID = 2,
                            ActorRole = "Garavel",
                            FilmID = 1
                        },
                        new
                        {
                            FAID = 3,
                            ActorID = 3,
                            ActorRole = "Mann",
                            FilmID = 2
                        });
                });

            modelBuilder.Entity("WebCRUD.Models.Film", b =>
                {
                    b.HasOne("WebCRUD.Models.Category", "Category")
                        .WithMany("Films")
                        .HasForeignKey("CategoryID");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("WebCRUD.Models.FilmActor", b =>
                {
                    b.HasOne("WebCRUD.Models.Actor", "Actor")
                        .WithMany("Films")
                        .HasForeignKey("ActorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebCRUD.Models.Film", "Film")
                        .WithMany("Actors")
                        .HasForeignKey("FilmID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Actor");

                    b.Navigation("Film");
                });

            modelBuilder.Entity("WebCRUD.Models.Actor", b =>
                {
                    b.Navigation("Films");
                });

            modelBuilder.Entity("WebCRUD.Models.Category", b =>
                {
                    b.Navigation("Films");
                });

            modelBuilder.Entity("WebCRUD.Models.Film", b =>
                {
                    b.Navigation("Actors");
                });
#pragma warning restore 612, 618
        }
    }
}