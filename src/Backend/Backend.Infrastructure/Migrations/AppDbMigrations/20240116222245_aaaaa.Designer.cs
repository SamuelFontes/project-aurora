﻿// <auto-generated />
using System;
using Backend.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Backend.Infrastructure.Migrations.AppDbMigrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240116222245_aaaaa")]
    partial class aaaaa
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.HasPostgresExtension(modelBuilder, "uuid-ossp");
            NpgsqlModelBuilderExtensions.UseSerialColumns(modelBuilder);

            modelBuilder.Entity("Backend.Domain.Entities.Agent.Agent", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<bool>("Active")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<Guid>("TenantId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("UpdatedBy")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.ToTable("Agent");
                });

            modelBuilder.Entity("Backend.Domain.Entities.Categories.Category", b =>
                {
                    b.Property<Guid>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<bool>("Active")
                        .HasColumnType("boolean");

                    b.Property<string>("CategoryName")
                        .HasColumnType("text");

                    b.Property<DateTime?>("Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<Guid>("TenantId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("UpdatedBy")
                        .HasColumnType("uuid");

                    b.HasKey("CategoryId");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            CategoryId = new Guid("63cf51c6-e90e-4725-b6c3-1c40986d6847"),
                            Active = true,
                            CategoryName = "Eletronic",
                            Created = new DateTime(2024, 1, 16, 22, 22, 45, 496, DateTimeKind.Utc).AddTicks(412),
                            TenantId = new Guid("cabaa57a-37ff-4871-be7d-0187ed3534a5")
                        });
                });

            modelBuilder.Entity("Backend.Domain.Entities.ProductTypes.ProductType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<bool>("Active")
                        .HasColumnType("boolean");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("ProductType");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Active = true,
                            Description = "Crafting material",
                            Name = "Feedstock"
                        },
                        new
                        {
                            Id = 2,
                            Active = true,
                            Description = "Intermediate Product/Crafting material",
                            Name = "Intermediate Component"
                        },
                        new
                        {
                            Id = 3,
                            Active = true,
                            Description = "Final Product",
                            Name = "Product"
                        });
                });

            modelBuilder.Entity("Backend.Domain.Entities.Products.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<bool>("Active")
                        .HasColumnType("boolean");

                    b.Property<Guid?>("CategoryId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("GTIN")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double?>("LiquidWeight")
                        .HasColumnType("double precision");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ProductTypeId")
                        .HasColumnType("integer");

                    b.Property<string>("SKU")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid?>("SubCategoryId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("TenantId")
                        .HasColumnType("uuid");

                    b.Property<double?>("TotalWeight")
                        .HasColumnType("double precision");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("UpdatedBy")
                        .HasColumnType("uuid");

                    b.Property<double>("Value")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ProductTypeId");

                    b.HasIndex("SubCategoryId");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            Id = new Guid("b60a6598-4627-4499-bf42-5d4bac3be8da"),
                            Active = true,
                            CategoryId = new Guid("63cf51c6-e90e-4725-b6c3-1c40986d6847"),
                            Created = new DateTime(2024, 1, 16, 22, 22, 45, 496, DateTimeKind.Utc).AddTicks(570),
                            Description = "Produto de teste gerado na migration - Aurora",
                            GTIN = "012345678910111213",
                            LiquidWeight = 0.13,
                            Name = "Samsung Galaxy S4",
                            ProductTypeId = 3,
                            SKU = "202401",
                            SubCategoryId = new Guid("cb1dd75f-6cf2-4c6e-b050-ee80444ad1c6"),
                            TenantId = new Guid("cabaa57a-37ff-4871-be7d-0187ed3534a5"),
                            TotalWeight = 0.13,
                            Value = 604.99000000000001
                        },
                        new
                        {
                            Id = new Guid("82371367-6100-45e7-be5a-0845afa8c886"),
                            Active = true,
                            Created = new DateTime(2024, 1, 16, 22, 22, 45, 496, DateTimeKind.Utc).AddTicks(584),
                            Description = "Produto de teste gerado na migration - SampleCompany",
                            GTIN = "012345678910111213",
                            LiquidWeight = 0.0,
                            Name = "Motorola Moto E",
                            ProductTypeId = 3,
                            SKU = "202401",
                            TenantId = new Guid("ae100414-8fbb-4286-839a-5bafc51a84fb"),
                            TotalWeight = 0.0,
                            Value = 100.0
                        });
                });

            modelBuilder.Entity("Backend.Domain.Entities.SubCategories.SubCategory", b =>
                {
                    b.Property<Guid>("SubCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<bool>("Active")
                        .HasColumnType("boolean");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<string>("SubCategoryName")
                        .HasColumnType("text");

                    b.Property<Guid>("TenantId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("UpdatedBy")
                        .HasColumnType("uuid");

                    b.HasKey("SubCategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("SubCategory");

                    b.HasData(
                        new
                        {
                            SubCategoryId = new Guid("cb1dd75f-6cf2-4c6e-b050-ee80444ad1c6"),
                            Active = true,
                            CategoryId = new Guid("63cf51c6-e90e-4725-b6c3-1c40986d6847"),
                            Created = new DateTime(2024, 1, 16, 22, 22, 45, 496, DateTimeKind.Utc).AddTicks(513),
                            SubCategoryName = "Smartphone",
                            TenantId = new Guid("cabaa57a-37ff-4871-be7d-0187ed3534a5")
                        });
                });

            modelBuilder.Entity("Backend.Domain.Entities.Products.Product", b =>
                {
                    b.HasOne("Backend.Domain.Entities.Categories.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");

                    b.HasOne("Backend.Domain.Entities.ProductTypes.ProductType", "ProductType")
                        .WithMany()
                        .HasForeignKey("ProductTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Backend.Domain.Entities.SubCategories.SubCategory", "SubCategory")
                        .WithMany()
                        .HasForeignKey("SubCategoryId");

                    b.Navigation("Category");

                    b.Navigation("ProductType");

                    b.Navigation("SubCategory");
                });

            modelBuilder.Entity("Backend.Domain.Entities.SubCategories.SubCategory", b =>
                {
                    b.HasOne("Backend.Domain.Entities.Categories.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
