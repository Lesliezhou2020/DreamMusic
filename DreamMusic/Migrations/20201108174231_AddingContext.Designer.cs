﻿// <auto-generated />
using System;
using DreamMusic.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DreamMusic.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20201108174231_AddingContext")]
    partial class AddingContext
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("DreamMusic.Models.DrumSheet", b =>
                {
                    b.Property<int>("SheetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Crash")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("CreatorId")
                        .HasColumnType("int");

                    b.Property<string>("FloorTom")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("HiHatClose")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("HiHatOpen")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("HighTom")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Kick")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("MidTom")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Ride")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Snare")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("SheetId");

                    b.HasIndex("CreatorId");

                    b.ToTable("DrumSheets");
                });

            modelBuilder.Entity("DreamMusic.Models.Like", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("SheetId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SheetId");

                    b.HasIndex("UserId");

                    b.ToTable("Likes");
                });

            modelBuilder.Entity("DreamMusic.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DreamMusic.Models.DrumSheet", b =>
                {
                    b.HasOne("DreamMusic.Models.User", "Creator")
                        .WithMany("DrumSheets")
                        .HasForeignKey("CreatorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DreamMusic.Models.Like", b =>
                {
                    b.HasOne("DreamMusic.Models.DrumSheet", "Sheet")
                        .WithMany("Likes")
                        .HasForeignKey("SheetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DreamMusic.Models.User", "User")
                        .WithMany("Likes")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
