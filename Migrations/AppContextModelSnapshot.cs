﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using proiect_daw.Entities;

namespace proiect_daw.Migrations
{
    [DbContext(typeof(AppContext))]
    partial class AppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("proiect_daw.Entities.Bodykit", b =>
                {
                    b.Property<int>("BodykitID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CarBrand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CarID")
                        .HasColumnType("int");

                    b.Property<string>("CarModel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("BodykitID");

                    b.HasIndex("CarID");

                    b.ToTable("Bodykits");
                });

            modelBuilder.Entity("proiect_daw.Entities.Car", b =>
                {
                    b.Property<int>("CarID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Battery_Capacity")
                        .HasColumnType("int");

                    b.Property<int>("BodykitID")
                        .HasColumnType("int");

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Cubic_Capacity")
                        .HasColumnType("int");

                    b.Property<string>("Fuel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HP")
                        .HasColumnType("int");

                    b.Property<int>("HistoryID")
                        .HasColumnType("int");

                    b.Property<long>("Mileage")
                        .HasColumnType("bigint");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OwnerID")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("Transmission")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VIN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("CarID");

                    b.HasIndex("OwnerID");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("proiect_daw.Entities.CarRim", b =>
                {
                    b.Property<int>("CarID")
                        .HasColumnType("int");

                    b.Property<int>("RimID")
                        .HasColumnType("int");

                    b.HasKey("CarID", "RimID");

                    b.HasIndex("RimID");

                    b.ToTable("CarRims");
                });

            modelBuilder.Entity("proiect_daw.Entities.History", b =>
                {
                    b.Property<int>("HistoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CarHistory")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CarID")
                        .HasColumnType("int");

                    b.HasKey("HistoryID");

                    b.HasIndex("CarID")
                        .IsUnique();

                    b.ToTable("Histories");
                });

            modelBuilder.Entity("proiect_daw.Entities.Owner", b =>
                {
                    b.Property<int>("OwnerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telephone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OwnerID");

                    b.ToTable("Owners");
                });

            modelBuilder.Entity("proiect_daw.Entities.Rim", b =>
                {
                    b.Property<int>("RimID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ET")
                        .HasColumnType("int");

                    b.Property<int>("HubSize")
                        .HasColumnType("int");

                    b.Property<int>("J")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("Size")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("RimID");

                    b.ToTable("Rims");
                });

            modelBuilder.Entity("proiect_daw.Entities.Bodykit", b =>
                {
                    b.HasOne("proiect_daw.Entities.Car", "Car")
                        .WithMany("Bodykits")
                        .HasForeignKey("CarID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");
                });

            modelBuilder.Entity("proiect_daw.Entities.Car", b =>
                {
                    b.HasOne("proiect_daw.Entities.Owner", "Owner")
                        .WithMany("Cars")
                        .HasForeignKey("OwnerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("proiect_daw.Entities.CarRim", b =>
                {
                    b.HasOne("proiect_daw.Entities.Car", "Car")
                        .WithMany("CarRims")
                        .HasForeignKey("CarID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("proiect_daw.Entities.Rim", "Rim")
                        .WithMany("CarRims")
                        .HasForeignKey("RimID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");

                    b.Navigation("Rim");
                });

            modelBuilder.Entity("proiect_daw.Entities.History", b =>
                {
                    b.HasOne("proiect_daw.Entities.Car", "Car")
                        .WithOne("History")
                        .HasForeignKey("proiect_daw.Entities.History", "CarID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");
                });

            modelBuilder.Entity("proiect_daw.Entities.Car", b =>
                {
                    b.Navigation("Bodykits");

                    b.Navigation("CarRims");

                    b.Navigation("History");
                });

            modelBuilder.Entity("proiect_daw.Entities.Owner", b =>
                {
                    b.Navigation("Cars");
                });

            modelBuilder.Entity("proiect_daw.Entities.Rim", b =>
                {
                    b.Navigation("CarRims");
                });
#pragma warning restore 612, 618
        }
    }
}
