﻿// <auto-generated />
using AbcHealthCareApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AbcHealthCareApi.Data.Migrations
{
    [DbContext(typeof(StoreContext))]
    [Migration("20221014135437_BasketEntityAdded")]
    partial class BasketEntityAdded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.8");

            modelBuilder.Entity("AbcHealthCareApi.Entities.Basket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BuyerId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Baskets");
                });

            modelBuilder.Entity("AbcHealthCareApi.Entities.BasketItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BasketId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MedicineId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("BasketId");

                    b.HasIndex("MedicineId");

                    b.ToTable("BasketItems");
                });

            modelBuilder.Entity("AbcHealthCareApi.Entities.Medicine", b =>
                {
                    b.Property<int>("IdMed")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("DescriptionMed")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImagePathMed")
                        .HasColumnType("TEXT");

                    b.Property<string>("NameMed")
                        .HasColumnType("TEXT");

                    b.Property<int>("PriceMed")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SellerMed")
                        .HasColumnType("TEXT");

                    b.HasKey("IdMed");

                    b.ToTable("medicines");
                });

            modelBuilder.Entity("AbcHealthCareApi.Entities.BasketItem", b =>
                {
                    b.HasOne("AbcHealthCareApi.Entities.Basket", "Basket")
                        .WithMany("Items")
                        .HasForeignKey("BasketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AbcHealthCareApi.Entities.Medicine", "Medicine")
                        .WithMany()
                        .HasForeignKey("MedicineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Basket");

                    b.Navigation("Medicine");
                });

            modelBuilder.Entity("AbcHealthCareApi.Entities.Basket", b =>
                {
                    b.Navigation("Items");
                });
#pragma warning restore 612, 618
        }
    }
}
