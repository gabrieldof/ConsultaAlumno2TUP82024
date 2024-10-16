﻿// <auto-generated />
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Web.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241010013550_AddSubjectdataseed")]
    partial class AddSubjectdataseed
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("Domain.Entities.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Quarter")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Subjects");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Programación",
                            Quarter = "Primer"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Base de datos",
                            Quarter = "Primer"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Análisis de Sistemas",
                            Quarter = "Segundo"
                        });
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("UserType")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "hola@gmail.com",
                            LastName = "Furrer",
                            Name = "Gabriel",
                            Password = "1234",
                            UserName = "gfurrer",
                            UserType = "professor"
                        },
                        new
                        {
                            Id = 2,
                            Email = "hola@gmail.com",
                            LastName = "Perez",
                            Name = "Carlos",
                            Password = "1234",
                            UserName = "cperez",
                            UserType = "student"
                        },
                        new
                        {
                            Id = 3,
                            Email = "hola@gmail.com",
                            LastName = "Rodriguez",
                            Name = "Pedro",
                            Password = "1234",
                            UserName = "prodriguez",
                            UserType = "professor"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
