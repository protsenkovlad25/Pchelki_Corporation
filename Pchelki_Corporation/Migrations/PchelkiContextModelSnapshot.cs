﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pchelki_Corporation.Models.Entityes;

namespace Pchelki_Corporation.Migrations
{
    [DbContext(typeof(PchelkiContext))]
    partial class PchelkiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Pchelki_Corporation.Models.Entityes.Bee_Garden", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Home")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Square")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Town")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Bee_Gardens");
                });

            modelBuilder.Entity("Pchelki_Corporation.Models.Entityes.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date_of_Birth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Father_Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("First_Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Home")
                        .HasColumnType("int");

                    b.Property<string>("Phone_Number")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Second_Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Town")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("Pchelki_Corporation.Models.Entityes.Disease", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Diseases");
                });

            modelBuilder.Entity("Pchelki_Corporation.Models.Entityes.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date_of_Birth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Father_Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("First_Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Home")
                        .HasColumnType("int");

                    b.Property<string>("Phone_Number")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Second_Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Town")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Pchelki_Corporation.Models.Entityes.Employee_by_Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("PostId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("PostId");

                    b.ToTable("Employees_by_Posts");
                });

            modelBuilder.Entity("Pchelki_Corporation.Models.Entityes.Equipment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Equipments");
                });

            modelBuilder.Entity("Pchelki_Corporation.Models.Entityes.Family", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Bee_GardenId")
                        .HasColumnType("int");

                    b.Property<int>("Productivity")
                        .HasColumnType("int");

                    b.Property<string>("Reproduction")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Type_of_BeehivesId")
                        .HasColumnType("int");

                    b.Property<int>("Type_of_BeesId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Bee_GardenId");

                    b.HasIndex("Type_of_BeehivesId");

                    b.HasIndex("Type_of_BeesId");

                    b.ToTable("Families");
                });

            modelBuilder.Entity("Pchelki_Corporation.Models.Entityes.Healing", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Healings");
                });

            modelBuilder.Entity("Pchelki_Corporation.Models.Entityes.Healing_of_Disease", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DiseaseId")
                        .HasColumnType("int");

                    b.Property<int>("HealingId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DiseaseId");

                    b.HasIndex("HealingId");

                    b.ToTable("Healings_of_Diseases");
                });

            modelBuilder.Entity("Pchelki_Corporation.Models.Entityes.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Salary")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("Pchelki_Corporation.Models.Entityes.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Pchelki_Corporation.Models.Entityes.Product_Sold", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("SaleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("SaleId");

                    b.ToTable("Product_Solds");
                });

            modelBuilder.Entity("Pchelki_Corporation.Models.Entityes.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Square")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("Pchelki_Corporation.Models.Entityes.Sale", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Sales");
                });

            modelBuilder.Entity("Pchelki_Corporation.Models.Entityes.Sick", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DiseaseId")
                        .HasColumnType("int");

                    b.Property<int>("FamilyId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DiseaseId");

                    b.HasIndex("FamilyId");

                    b.ToTable("Sicks");
                });

            modelBuilder.Entity("Pchelki_Corporation.Models.Entityes.Sign", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Signs");
                });

            modelBuilder.Entity("Pchelki_Corporation.Models.Entityes.Sign_of_Disease", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DiseaseId")
                        .HasColumnType("int");

                    b.Property<int>("SignId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DiseaseId");

                    b.HasIndex("SignId");

                    b.ToTable("Signs_of_Diseases");
                });

            modelBuilder.Entity("Pchelki_Corporation.Models.Entityes.Tabel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount_Product")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date_Event")
                        .HasColumnType("datetime2");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("EquipmentId")
                        .HasColumnType("int");

                    b.Property<int>("FamilyId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("RoomId")
                        .HasColumnType("int");

                    b.Property<int>("WorkId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("EquipmentId");

                    b.HasIndex("FamilyId");

                    b.HasIndex("ProductId");

                    b.HasIndex("RoomId");

                    b.HasIndex("WorkId");

                    b.ToTable("Tabels");
                });

            modelBuilder.Entity("Pchelki_Corporation.Models.Entityes.Type_of_Beehives", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount_Frame")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Size_Beehive")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Size_Frame")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Types_of_Beehives");
                });

            modelBuilder.Entity("Pchelki_Corporation.Models.Entityes.Type_of_Bees", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Productivity_of_Bees")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Types_of_Bees");
                });

            modelBuilder.Entity("Pchelki_Corporation.Models.Entityes.Type_of_Work", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Types_of_Work");
                });

            modelBuilder.Entity("Pchelki_Corporation.Models.Entityes.Work", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Type_of_WorkId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Type_of_WorkId");

                    b.ToTable("Works");
                });

            modelBuilder.Entity("Pchelki_Corporation.Models.Entityes.Employee_by_Post", b =>
                {
                    b.HasOne("Pchelki_Corporation.Models.Entityes.Employee", "Employee")
                        .WithMany("Employees_by_Posts")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pchelki_Corporation.Models.Entityes.Post", "Post")
                        .WithMany("Employees_by_Posts")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Post");
                });

            modelBuilder.Entity("Pchelki_Corporation.Models.Entityes.Family", b =>
                {
                    b.HasOne("Pchelki_Corporation.Models.Entityes.Bee_Garden", "Bee_Garden")
                        .WithMany("Families")
                        .HasForeignKey("Bee_GardenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pchelki_Corporation.Models.Entityes.Type_of_Beehives", "Type_of_Beehives")
                        .WithMany("Families")
                        .HasForeignKey("Type_of_BeehivesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pchelki_Corporation.Models.Entityes.Type_of_Bees", "Type_of_Bees")
                        .WithMany("Families")
                        .HasForeignKey("Type_of_BeesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bee_Garden");

                    b.Navigation("Type_of_Beehives");

                    b.Navigation("Type_of_Bees");
                });

            modelBuilder.Entity("Pchelki_Corporation.Models.Entityes.Healing_of_Disease", b =>
                {
                    b.HasOne("Pchelki_Corporation.Models.Entityes.Disease", "Disease")
                        .WithMany("Healings_of_Diseases")
                        .HasForeignKey("DiseaseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pchelki_Corporation.Models.Entityes.Healing", "Healing")
                        .WithMany("Healings_Of_Diseases")
                        .HasForeignKey("HealingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Disease");

                    b.Navigation("Healing");
                });

            modelBuilder.Entity("Pchelki_Corporation.Models.Entityes.Product_Sold", b =>
                {
                    b.HasOne("Pchelki_Corporation.Models.Entityes.Product", "Product")
                        .WithMany("Products_Sold")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pchelki_Corporation.Models.Entityes.Sale", "Sale")
                        .WithMany("Products_Sold")
                        .HasForeignKey("SaleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Sale");
                });

            modelBuilder.Entity("Pchelki_Corporation.Models.Entityes.Sale", b =>
                {
                    b.HasOne("Pchelki_Corporation.Models.Entityes.Client", "Client")
                        .WithMany("Sales")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pchelki_Corporation.Models.Entityes.Employee", "Employee")
                        .WithMany("Sales")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("Pchelki_Corporation.Models.Entityes.Sick", b =>
                {
                    b.HasOne("Pchelki_Corporation.Models.Entityes.Disease", "Disease")
                        .WithMany("Sicks")
                        .HasForeignKey("DiseaseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pchelki_Corporation.Models.Entityes.Family", "Family")
                        .WithMany("Sicks")
                        .HasForeignKey("FamilyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Disease");

                    b.Navigation("Family");
                });

            modelBuilder.Entity("Pchelki_Corporation.Models.Entityes.Sign_of_Disease", b =>
                {
                    b.HasOne("Pchelki_Corporation.Models.Entityes.Disease", "Disease")
                        .WithMany("Signs_of_Diseases")
                        .HasForeignKey("DiseaseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pchelki_Corporation.Models.Entityes.Sign", "Sign")
                        .WithMany("Signs_of_Diseases")
                        .HasForeignKey("SignId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Disease");

                    b.Navigation("Sign");
                });

            modelBuilder.Entity("Pchelki_Corporation.Models.Entityes.Tabel", b =>
                {
                    b.HasOne("Pchelki_Corporation.Models.Entityes.Employee", "Employee")
                        .WithMany("Tabels")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pchelki_Corporation.Models.Entityes.Equipment", "Equipment")
                        .WithMany("Tabels")
                        .HasForeignKey("EquipmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pchelki_Corporation.Models.Entityes.Family", "Family")
                        .WithMany("Tabels")
                        .HasForeignKey("FamilyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pchelki_Corporation.Models.Entityes.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pchelki_Corporation.Models.Entityes.Room", "Room")
                        .WithMany("Tabels")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pchelki_Corporation.Models.Entityes.Work", "Work")
                        .WithMany("Tabels")
                        .HasForeignKey("WorkId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Equipment");

                    b.Navigation("Family");

                    b.Navigation("Product");

                    b.Navigation("Room");

                    b.Navigation("Work");
                });

            modelBuilder.Entity("Pchelki_Corporation.Models.Entityes.Work", b =>
                {
                    b.HasOne("Pchelki_Corporation.Models.Entityes.Type_of_Work", "Type_of_Work")
                        .WithMany("Works")
                        .HasForeignKey("Type_of_WorkId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Type_of_Work");
                });

            modelBuilder.Entity("Pchelki_Corporation.Models.Entityes.Bee_Garden", b =>
                {
                    b.Navigation("Families");
                });

            modelBuilder.Entity("Pchelki_Corporation.Models.Entityes.Client", b =>
                {
                    b.Navigation("Sales");
                });

            modelBuilder.Entity("Pchelki_Corporation.Models.Entityes.Disease", b =>
                {
                    b.Navigation("Healings_of_Diseases");

                    b.Navigation("Sicks");

                    b.Navigation("Signs_of_Diseases");
                });

            modelBuilder.Entity("Pchelki_Corporation.Models.Entityes.Employee", b =>
                {
                    b.Navigation("Employees_by_Posts");

                    b.Navigation("Sales");

                    b.Navigation("Tabels");
                });

            modelBuilder.Entity("Pchelki_Corporation.Models.Entityes.Equipment", b =>
                {
                    b.Navigation("Tabels");
                });

            modelBuilder.Entity("Pchelki_Corporation.Models.Entityes.Family", b =>
                {
                    b.Navigation("Sicks");

                    b.Navigation("Tabels");
                });

            modelBuilder.Entity("Pchelki_Corporation.Models.Entityes.Healing", b =>
                {
                    b.Navigation("Healings_Of_Diseases");
                });

            modelBuilder.Entity("Pchelki_Corporation.Models.Entityes.Post", b =>
                {
                    b.Navigation("Employees_by_Posts");
                });

            modelBuilder.Entity("Pchelki_Corporation.Models.Entityes.Product", b =>
                {
                    b.Navigation("Products_Sold");
                });

            modelBuilder.Entity("Pchelki_Corporation.Models.Entityes.Room", b =>
                {
                    b.Navigation("Tabels");
                });

            modelBuilder.Entity("Pchelki_Corporation.Models.Entityes.Sale", b =>
                {
                    b.Navigation("Products_Sold");
                });

            modelBuilder.Entity("Pchelki_Corporation.Models.Entityes.Sign", b =>
                {
                    b.Navigation("Signs_of_Diseases");
                });

            modelBuilder.Entity("Pchelki_Corporation.Models.Entityes.Type_of_Beehives", b =>
                {
                    b.Navigation("Families");
                });

            modelBuilder.Entity("Pchelki_Corporation.Models.Entityes.Type_of_Bees", b =>
                {
                    b.Navigation("Families");
                });

            modelBuilder.Entity("Pchelki_Corporation.Models.Entityes.Type_of_Work", b =>
                {
                    b.Navigation("Works");
                });

            modelBuilder.Entity("Pchelki_Corporation.Models.Entityes.Work", b =>
                {
                    b.Navigation("Tabels");
                });
#pragma warning restore 612, 618
        }
    }
}
