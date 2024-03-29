﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ScoreboardChallenge.Data;

namespace ScoreboardChallenge.Migrations
{
    [DbContext(typeof(PlayerPointDbContext))]
    [Migration("20191216161749_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0");

            modelBuilder.Entity("ScoreboardChallenge.Model.PlayerPointModel", b =>
                {
                    b.Property<int>("PlayerPointId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("PlayerName")
                        .HasColumnType("TEXT");

                    b.Property<double>("Points")
                        .HasColumnType("REAL");

                    b.HasKey("PlayerPointId");

                    b.ToTable("PlayerPoint");
                });
#pragma warning restore 612, 618
        }
    }
}
