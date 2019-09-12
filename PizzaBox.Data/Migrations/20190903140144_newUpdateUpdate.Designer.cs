﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PizzaBox.Data;

namespace PizzaBox.Data.Migrations
{
    [DbContext(typeof(PizzaBoxDbContext))]
    [Migration("20190903140144_newUpdateUpdate")]
    partial class newUpdateUpdate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PizzaBox.Domain.Crust", b =>
                {
                    b.Property<int>("CrustId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("CrustCost");

                    b.Property<string>("CrustName")
                        .IsRequired();

                    b.HasKey("CrustId");

                    b.HasIndex("CrustName")
                        .IsUnique();

                    b.ToTable("Crust");
                });

            modelBuilder.Entity("PizzaBox.Domain.History", b =>
                {
                    b.Property<int>("HistoryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OrderId");

                    b.Property<int>("UserId");

                    b.HasKey("HistoryId");

                    b.ToTable("History");
                });

            modelBuilder.Entity("PizzaBox.Domain.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LocationName")
                        .IsRequired();

                    b.HasKey("LocationId");

                    b.HasIndex("LocationName")
                        .IsUnique();

                    b.ToTable("Location");
                });

            modelBuilder.Entity("PizzaBox.Domain.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LocationId");

                    b.Property<decimal>("OrderCost");

                    b.HasKey("OrderId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("PizzaBox.Domain.Pizza", b =>
                {
                    b.Property<int>("PizzaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CrustId");

                    b.Property<int>("OrderId");

                    b.Property<decimal>("PizzaCost");

                    b.Property<int>("SizeId");

                    b.HasKey("PizzaId");

                    b.ToTable("Pizza");
                });

            modelBuilder.Entity("PizzaBox.Domain.Size", b =>
                {
                    b.Property<int>("SizeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("SizeCost");

                    b.Property<string>("SizeName")
                        .IsRequired();

                    b.HasKey("SizeId");

                    b.HasIndex("SizeName")
                        .IsUnique();

                    b.ToTable("Size");
                });

            modelBuilder.Entity("PizzaBox.Domain.Store", b =>
                {
                    b.Property<int>("StoreId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("StoreId");

                    b.ToTable("Store");
                });

            modelBuilder.Entity("PizzaBox.Domain.Topping", b =>
                {
                    b.Property<int>("ToppingId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("ToppingsCost");

                    b.Property<string>("ToppingsName")
                        .IsRequired();

                    b.HasKey("ToppingId");

                    b.HasIndex("ToppingsName")
                        .IsUnique();

                    b.ToTable("Topping");
                });

            modelBuilder.Entity("PizzaBox.Domain.ToppingsOrder", b =>
                {
                    b.Property<int>("ToppingsOrderId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PizzaId");

                    b.Property<int>("ToppingId");

                    b.HasKey("ToppingsOrderId");

                    b.ToTable("ToppingsOrder");
                });

            modelBuilder.Entity("PizzaBox.Domain.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("HistoryId");

                    b.Property<string>("Username")
                        .IsRequired();

                    b.HasKey("UserId");

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("User");
                });
#pragma warning restore 612, 618
        }
    }
}
