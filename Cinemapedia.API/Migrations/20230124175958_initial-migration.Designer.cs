﻿// <auto-generated />
using System;
using Cinemapedia.API;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Cinemapedia.API.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230124175958_initial-migration")]
    partial class initialmigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Cinemapedia.API.Model.Movie", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("varchar(500)")
                        .HasColumnName("description");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("director");

                    b.Property<double>("Rating")
                        .HasColumnType("float")
                        .HasColumnName("Rating");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("DATE")
                        .HasColumnName("release");

                    b.Property<int>("Status")
                        .HasColumnType("int")
                        .HasColumnName("status");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Title");

                    b.HasKey("Id")
                        .HasName("id_movie");

                    b.ToTable("tb_movie", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
