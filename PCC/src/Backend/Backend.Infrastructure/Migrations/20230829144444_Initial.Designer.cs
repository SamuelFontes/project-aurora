﻿// <auto-generated />
using System;
using Backend.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Backend.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230829144444_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseSerialColumns(modelBuilder);

            modelBuilder.Entity("Backend.Domain.Entities.Products.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int?>("CestId")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<decimal?>("LiquidWeight")
                        .HasColumnType("numeric");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int?>("NcmId")
                        .HasColumnType("integer");

                    b.Property<Guid?>("ProductTypeId")
                        .IsRequired()
                        .HasColumnType("uuid");

                    b.Property<string>("SKU")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("TaxUnitId")
                        .HasColumnType("integer");

                    b.Property<decimal?>("TotalWeight")
                        .HasColumnType("numeric");

                    b.Property<decimal>("Value")
                        .HasColumnType("numeric");

                    b.Property<string>("cEAN")
                        .HasColumnType("text");

                    b.Property<string>("cEANTax")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ProductTypeId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("Backend.Domain.Entities.Products.ProductType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("ProductTypes");
                });

            modelBuilder.Entity("Backend.Domain.Entities.Products.Product", b =>
                {
                    b.HasOne("Backend.Domain.Entities.Products.ProductType", "ProductTypes")
                        .WithMany()
                        .HasForeignKey("ProductTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductTypes");
                });
#pragma warning restore 612, 618
        }
    }
}
