﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RazorPagesMovie.Data;

#nullable disable

namespace RazorPagesMovie.Migrations
{
    [DbContext(typeof(RazorPagesMovieContext))]
    [Migration("20230603033656_notes")]
    partial class notes
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("RazorPagesMovie.Models.Scripture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Book")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("TEXT");

                    b.Property<int>("Chapter")
                        .HasMaxLength(30)
                        .HasColumnType("INTEGER");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("Verses")
                        .HasMaxLength(5)
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Scripture");
                });
#pragma warning restore 612, 618
        }
    }
}
