﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NTierCalisma1.DATAACCESS.Context;

#nullable disable

namespace NTierCalisma1.DATAACCESS.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220109122821_first")]
    partial class first
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("NTierCalisma1.ENTITIES.Entities.Category", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ID");

                    b.Property<string>("CreatedADUserName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Oluşturulan Kullanıcı Admin Adı");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int")
                        .HasColumnName("Oluşturan Kişi");

                    b.Property<string>("CreatedComputerName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Oluşturulan Bilgisayar Adı");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Oluşturulma Zamanı");

                    b.Property<string>("CreatedIP")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Oluşturulan IP Adresi");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("MasterID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ModifiedADUserName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Güncellenen Kullanıcı Admin Adı");

                    b.Property<int?>("ModifiedBy")
                        .HasColumnType("int")
                        .HasColumnName("Güncellenen Kişi");

                    b.Property<string>("ModifiedComputerName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Güncellenen Bilgisayar Adı");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Güncellenen Zamanı");

                    b.Property<string>("ModifiedIP")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Güncellenen IP Adresi");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("NTierCalisma1.ENTITIES.Entities.Order", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ID");

                    b.Property<bool>("Confirmed")
                        .HasColumnType("bit");

                    b.Property<string>("CreatedADUserName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Oluşturulan Kullanıcı Admin Adı");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int")
                        .HasColumnName("Oluşturan Kişi");

                    b.Property<string>("CreatedComputerName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Oluşturulan Bilgisayar Adı");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Oluşturulma Zamanı");

                    b.Property<string>("CreatedIP")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Oluşturulan IP Adresi");

                    b.Property<Guid?>("MasterID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ModifiedADUserName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Güncellenen Kullanıcı Admin Adı");

                    b.Property<int?>("ModifiedBy")
                        .HasColumnType("int")
                        .HasColumnName("Güncellenen Kişi");

                    b.Property<string>("ModifiedComputerName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Güncellenen Bilgisayar Adı");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Güncellenen Zamanı");

                    b.Property<string>("ModifiedIP")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Güncellenen IP Adresi");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("NTierCalisma1.ENTITIES.Entities.OrderDetail", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ID");

                    b.Property<string>("CreatedADUserName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Oluşturulan Kullanıcı Admin Adı");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int")
                        .HasColumnName("Oluşturan Kişi");

                    b.Property<string>("CreatedComputerName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Oluşturulan Bilgisayar Adı");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Oluşturulma Zamanı");

                    b.Property<string>("CreatedIP")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Oluşturulan IP Adresi");

                    b.Property<Guid?>("MasterID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ModifiedADUserName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Güncellenen Kullanıcı Admin Adı");

                    b.Property<int?>("ModifiedBy")
                        .HasColumnType("int")
                        .HasColumnName("Güncellenen Kişi");

                    b.Property<string>("ModifiedComputerName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Güncellenen Bilgisayar Adı");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Güncellenen Zamanı");

                    b.Property<string>("ModifiedIP")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Güncellenen IP Adresi");

                    b.Property<Guid?>("OrderID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Quantity")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<decimal?>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ID");

                    b.HasIndex("OrderID");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("NTierCalisma1.ENTITIES.Entities.Product", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ID");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedADUserName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Oluşturulan Kullanıcı Admin Adı");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int")
                        .HasColumnName("Oluşturan Kişi");

                    b.Property<string>("CreatedComputerName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Oluşturulan Bilgisayar Adı");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Oluşturulma Zamanı");

                    b.Property<string>("CreatedIP")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Oluşturulan IP Adresi");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("MasterID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ModifiedADUserName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Güncellenen Kullanıcı Admin Adı");

                    b.Property<int?>("ModifiedBy")
                        .HasColumnType("int")
                        .HasColumnName("Güncellenen Kişi");

                    b.Property<string>("ModifiedComputerName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Güncellenen Bilgisayar Adı");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Güncellenen Zamanı");

                    b.Property<string>("ModifiedIP")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Güncellenen IP Adresi");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("QuantityPerUnit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int?>("Stock")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("NTierCalisma1.ENTITIES.Entities.User", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ID");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedADUserName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Oluşturulan Kullanıcı Admin Adı");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int")
                        .HasColumnName("Oluşturan Kişi");

                    b.Property<string>("CreatedComputerName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Oluşturulan Bilgisayar Adı");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Oluşturulma Zamanı");

                    b.Property<string>("CreatedIP")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Oluşturulan IP Adresi");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("MasterID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ModifiedADUserName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Güncellenen Kullanıcı Admin Adı");

                    b.Property<int?>("ModifiedBy")
                        .HasColumnType("int")
                        .HasColumnName("Güncellenen Kişi");

                    b.Property<string>("ModifiedComputerName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Güncellenen Bilgisayar Adı");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Güncellenen Zamanı");

                    b.Property<string>("ModifiedIP")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Güncellenen IP Adresi");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Role")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Surname")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("NTierCalisma1.ENTITIES.Entities.Order", b =>
                {
                    b.HasOne("NTierCalisma1.ENTITIES.Entities.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("NTierCalisma1.ENTITIES.Entities.OrderDetail", b =>
                {
                    b.HasOne("NTierCalisma1.ENTITIES.Entities.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderID");

                    b.HasOne("NTierCalisma1.ENTITIES.Entities.Product", "Product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("NTierCalisma1.ENTITIES.Entities.Product", b =>
                {
                    b.HasOne("NTierCalisma1.ENTITIES.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("NTierCalisma1.ENTITIES.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("NTierCalisma1.ENTITIES.Entities.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("NTierCalisma1.ENTITIES.Entities.Product", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("NTierCalisma1.ENTITIES.Entities.User", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
