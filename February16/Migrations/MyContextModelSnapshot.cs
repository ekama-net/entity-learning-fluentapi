﻿// <auto-generated />
using System;
using February16;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace February16.Migrations
{
    [DbContext(typeof(MyContext))]
    partial class MyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("February16.Delivery", b =>
                {
                    b.Property<int>("DeliveryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DeliveryId"), 1L, 1);

                    b.Property<bool>("HasDelivery")
                        .HasMaxLength(20)
                        .HasColumnType("bit");

                    b.HasKey("DeliveryId");

                    b.ToTable("Deliverys", (string)null);

                    b.HasData(
                        new
                        {
                            DeliveryId = 1,
                            HasDelivery = true
                        },
                        new
                        {
                            DeliveryId = 2,
                            HasDelivery = false
                        });
                });

            modelBuilder.Entity("February16.Food", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("FoodCount")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(1);

                    b.Property<string>("FoodName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int?>("HasDelivery")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(2);

                    b.HasKey("Id");

                    b.HasIndex("HasDelivery");

                    b.ToTable("Foods", (string)null);

                    b.HasCheckConstraint("FoodCount", "FoodCount > 0 AND FoodCount < 100");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FoodCount = 2,
                            FoodName = "Bread",
                            HasDelivery = 1
                        },
                        new
                        {
                            Id = 2,
                            FoodCount = 2,
                            FoodName = "Milk",
                            HasDelivery = 2
                        },
                        new
                        {
                            Id = 3,
                            FoodCount = 0,
                            FoodName = "Cucumber"
                        });
                });

            modelBuilder.Entity("February16.Shoes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("HasDelivery")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(2);

                    b.Property<int>("ShoesCount")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(1);

                    b.Property<string>("ShoesName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("HasDelivery");

                    b.ToTable("Shoes", (string)null);

                    b.HasCheckConstraint("ShoesCount", "ShoesCount > 0 AND ShoesCount < 100");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            HasDelivery = 1,
                            ShoesCount = 1,
                            ShoesName = "Nike"
                        },
                        new
                        {
                            Id = 2,
                            HasDelivery = 1,
                            ShoesCount = 3,
                            ShoesName = "Saucony"
                        },
                        new
                        {
                            Id = 3,
                            ShoesCount = 0,
                            ShoesName = "Adidas"
                        });
                });

            modelBuilder.Entity("February16.Food", b =>
                {
                    b.HasOne("February16.Delivery", "Delivery")
                        .WithMany("Foods")
                        .HasForeignKey("HasDelivery")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Delivery");
                });

            modelBuilder.Entity("February16.Shoes", b =>
                {
                    b.HasOne("February16.Delivery", "Delivery")
                        .WithMany("Shoes")
                        .HasForeignKey("HasDelivery")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Delivery");
                });

            modelBuilder.Entity("February16.Delivery", b =>
                {
                    b.Navigation("Foods");

                    b.Navigation("Shoes");
                });
#pragma warning restore 612, 618
        }
    }
}
