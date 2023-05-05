﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TRPO;

#nullable disable

namespace TRPO.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20230505153807_lenadded")]
    partial class lenadded
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("TRPO.product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("kmat")
                        .HasColumnType("TEXT");

                    b.Property<double>("krt")
                        .HasColumnType("REAL");

                    b.Property<int>("len")
                        .HasColumnType("INTEGER");

                    b.Property<string>("nmat")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("products");
                });
#pragma warning restore 612, 618
        }
    }
}
