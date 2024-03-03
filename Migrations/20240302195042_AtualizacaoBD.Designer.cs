﻿// <auto-generated />
using HotelCalifornia.API.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HotelCalifornia.API.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240302195042_AtualizacaoBD")]
    partial class AtualizacaoBD
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("HotelCalifornia.API.Models.Guest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("CellNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(90)
                        .HasColumnType("varchar(90)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("varchar(70)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Guests");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Rua Bela Vista N 900 Funcionários",
                            CellNumber = "31988809090",
                            Cpf = "1234556",
                            Email = "prc@example.com",
                            Name = "Patrick Richard Cruz",
                            Status = "No Hotel"
                        },
                        new
                        {
                            Id = 2,
                            Address = "Rua Bela Vista N 900 Funcionários",
                            CellNumber = "31988809090",
                            Cpf = "12345677",
                            Email = "prc@example.com",
                            Name = "Ricardo Teixeira",
                            Status = "No Hotel"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}