﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DemoDotNetMVC.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    partial class ApplicationDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.12");

            modelBuilder.Entity("DemoDotNetMVC.Models.Animal", b =>
                {
                    b.Property<int>("AnimalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AnimalName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("AnimalId");

                    b.ToTable("Animal");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Animal");
                });

            modelBuilder.Entity("DemoDotNetMVC.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryID");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("DemoDotNetMVC.Models.ChuyenNganh", b =>
                {
                    b.Property<int>("ChuyenNganhId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ChuyenNganhName")
                        .HasColumnType("TEXT");

                    b.Property<int>("KhoaId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ChuyenNganhId");

                    b.HasIndex("KhoaId");

                    b.ToTable("ChuyenNganh");
                });

            modelBuilder.Entity("DemoDotNetMVC.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("EmployeeName")
                        .HasColumnType("TEXT");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("INTEGER");

                    b.HasKey("EmployeeID");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("DemoDotNetMVC.Models.Khoa", b =>
                {
                    b.Property<int>("KhoaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("KhoaName")
                        .HasColumnType("TEXT");

                    b.HasKey("KhoaId");

                    b.ToTable("Khoa");
                });

            modelBuilder.Entity("DemoDotNetMVC.Models.Movies", b =>
                {
                    b.Property<string>("MoviesID")
                        .HasColumnType("TEXT");

                    b.Property<string>("MoviesName")
                        .HasColumnType("TEXT");

                    b.HasKey("MoviesID");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("DemoDotNetMVC.Models.Person", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PersonName")
                        .HasColumnType("TEXT");

                    b.HasKey("PersonId");

                    b.ToTable("Person");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Person");
                });

            modelBuilder.Entity("DemoDotNetMVC.Models.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ProductName")
                        .HasColumnType("TEXT");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UnitPrice")
                        .HasColumnType("INTEGER");

                    b.HasKey("ProductID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("DemoDotNetMVC.Models.Student", b =>
                {
                    b.Property<int>("StudentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Adress")
                        .HasColumnType("TEXT");

                    b.Property<string>("StudentName")
                        .HasColumnType("TEXT");

                    b.HasKey("StudentID");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("DemoDotNetMVC.Models.Cat", b =>
                {
                    b.HasBaseType("DemoDotNetMVC.Models.Animal");

                    b.Property<int>("CatlId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Giong")
                        .HasColumnType("TEXT");

                    b.HasDiscriminator().HasValue("Cat");
                });

            modelBuilder.Entity("DemoDotNetMVC.Models.Teacher", b =>
                {
                    b.HasBaseType("DemoDotNetMVC.Models.Person");

                    b.Property<string>("DiaChi")
                        .HasColumnType("TEXT");

                    b.Property<int>("TeacherId")
                        .HasColumnType("INTEGER");

                    b.HasDiscriminator().HasValue("Teacher");
                });

            modelBuilder.Entity("DemoDotNetMVC.Models.ChuyenNganh", b =>
                {
                    b.HasOne("DemoDotNetMVC.Models.Khoa", "Khoa")
                        .WithMany("ChuyenNganhs")
                        .HasForeignKey("KhoaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Khoa");
                });

            modelBuilder.Entity("DemoDotNetMVC.Models.Product", b =>
                {
                    b.HasOne("DemoDotNetMVC.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("DemoDotNetMVC.Models.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("DemoDotNetMVC.Models.Khoa", b =>
                {
                    b.Navigation("ChuyenNganhs");
                });
#pragma warning restore 612, 618
        }
    }
}
