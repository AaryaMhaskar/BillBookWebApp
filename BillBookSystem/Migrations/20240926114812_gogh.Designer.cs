﻿// <auto-generated />
using System;
using BillBookSystem.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BillBookSystem.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240926114812_gogh")]
    partial class gogh
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BillBookSystem.Models.Inventory", b =>
                {
                    b.Property<decimal>("SalesPrice")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<decimal>("PurchasePrice")
                        .HasColumnType("decimal(10, 2)");

                    b.HasKey("SalesPrice");

                    b.ToTable("inven");
                });

            modelBuilder.Entity("BillBookSystem.Models.Invoiced", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("InventoryItemId")
                        .HasColumnType("int");

                    b.Property<DateTime>("InvoiceDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("InvoiceId")
                        .HasColumnType("int");

                    b.Property<int>("SalesId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("invo");
                });

            modelBuilder.Entity("BillBookSystem.Models.SalesDetails", b =>
                {
                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("BillTo")
                        .HasColumnType("int");

                    b.Property<int>("InventoryItemid")
                        .HasColumnType("int");

                    b.Property<DateTime>("InvoiceDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("PurchasePrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("SalesPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Amount");

                    b.ToTable("salesdetails");
                });

            modelBuilder.Entity("BillBookSystem.Models.sale", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<int>("BillTo")
                        .HasColumnType("int");

                    b.Property<DateTime>("InvoiceDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("InvoiceId")
                        .HasColumnType("int");

                    b.Property<int>("InvoicedItemId")
                        .HasColumnType("int");

                    b.Property<int>("ShopTo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("sale");
                });
#pragma warning restore 612, 618
        }
    }
}
