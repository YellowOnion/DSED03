﻿// <auto-generated />
using DSED03;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using System;

namespace DatabaseInitCrap.Migrations
{
    [DbContext(typeof(ScoreContext))]
    [Migration("20171024021844_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452");

            modelBuilder.Entity("DSED03.Score", b =>
                {
                    b.Property<int>("ScoreId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Value");

                    b.Property<string>("Word");

                    b.HasKey("ScoreId");

                    b.ToTable("Scores");
                });
#pragma warning restore 612, 618
        }
    }
}