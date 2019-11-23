﻿// <auto-generated />
using System;
using BagelGram.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BagelGram.Data.Migrations
{
    [DbContext(typeof(BagelContext))]
    partial class BagelContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0");

            modelBuilder.Entity("BagelGram.Core.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ImageId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Text")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ImageId");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("BagelGram.Core.Models.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Caption")
                        .HasColumnType("TEXT");

                    b.Property<string>("Source")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Uploaded")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Images");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Caption = "Probably almost Bagel's first day home",
                            Source = "/uploads/2019-11-19-at-5.17.46.png",
                            Uploaded = new DateTime(2019, 11, 13, 16, 21, 52, 967, DateTimeKind.Local).AddTicks(2810),
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            Caption = "Chew toy on the head",
                            Source = "/uploads/2019-11-19-at-5.18.30.png",
                            Uploaded = new DateTime(2019, 11, 13, 16, 21, 52, 967, DateTimeKind.Local).AddTicks(2810),
                            UserId = 1
                        },
                        new
                        {
                            Id = 3,
                            Caption = "Smushed head dog",
                            Source = "/uploads/2019-11-19-at-5.19.01.png",
                            Uploaded = new DateTime(2019, 11, 13, 16, 21, 52, 967, DateTimeKind.Local).AddTicks(2810),
                            UserId = 1
                        },
                        new
                        {
                            Id = 4,
                            Caption = "First lazy sit captured",
                            Source = "/uploads/2019-11-19-at-5.19.40.png",
                            Uploaded = new DateTime(2019, 11, 13, 16, 21, 52, 967, DateTimeKind.Local).AddTicks(2810),
                            UserId = 1
                        },
                        new
                        {
                            Id = 5,
                            Caption = "And onto her second collar",
                            Source = "/uploads/2019-11-19-at-5.20.02.png",
                            Uploaded = new DateTime(2019, 11, 13, 16, 21, 52, 967, DateTimeKind.Local).AddTicks(2810),
                            UserId = 1
                        },
                        new
                        {
                            Id = 6,
                            Caption = "Frowning head bagel",
                            Source = "/uploads/2019-11-19-at-5.20.28.png",
                            Uploaded = new DateTime(2019, 11, 13, 16, 21, 52, 967, DateTimeKind.Local).AddTicks(2810),
                            UserId = 1
                        },
                        new
                        {
                            Id = 7,
                            Caption = "World's most forlorn dog",
                            Source = "/uploads/2019-11-19-at-5.20.45.png",
                            Uploaded = new DateTime(2019, 11, 13, 16, 21, 52, 967, DateTimeKind.Local).AddTicks(2810),
                            UserId = 1
                        },
                        new
                        {
                            Id = 8,
                            Caption = "Needy ass dog",
                            Source = "/uploads/2019-11-19-at-5.21.00.png",
                            Uploaded = new DateTime(2019, 11, 13, 16, 21, 52, 967, DateTimeKind.Local).AddTicks(2810),
                            UserId = 1
                        },
                        new
                        {
                            Id = 9,
                            Caption = "She used to fit on a chair",
                            Source = "/uploads/2019-11-19-at-5.21.26.png",
                            Uploaded = new DateTime(2019, 11, 13, 16, 21, 52, 967, DateTimeKind.Local).AddTicks(2810),
                            UserId = 1
                        },
                        new
                        {
                            Id = 10,
                            Caption = "Deer-ear dog",
                            Source = "/uploads/2019-11-19-at-5.21.52.png",
                            Uploaded = new DateTime(2019, 11, 13, 16, 21, 52, 967, DateTimeKind.Local).AddTicks(2810),
                            UserId = 1
                        });
                });

            modelBuilder.Entity("BagelGram.Core.Models.Like", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<int>("ImageId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ImageId");

                    b.HasIndex("UserId");

                    b.ToTable("Likes");
                });

            modelBuilder.Entity("BagelGram.Core.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BirthDate = new DateTime(2018, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserName = "bagel"
                        });
                });

            modelBuilder.Entity("BagelGram.Core.Models.Comment", b =>
                {
                    b.HasOne("BagelGram.Core.Models.Image", "Image")
                        .WithMany("Comments")
                        .HasForeignKey("ImageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BagelGram.Core.Models.User", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BagelGram.Core.Models.Image", b =>
                {
                    b.HasOne("BagelGram.Core.Models.User", "User")
                        .WithMany("Images")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BagelGram.Core.Models.Like", b =>
                {
                    b.HasOne("BagelGram.Core.Models.Image", "Image")
                        .WithMany("Likes")
                        .HasForeignKey("ImageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BagelGram.Core.Models.User", "User")
                        .WithMany("Likes")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
