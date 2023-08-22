﻿// <auto-generated />
using System;
using BeautyCenter.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BeautyCenter.Migrations
{
    [DbContext(typeof(BeautyDbContext))]
    [Migration("20230821215443_AllEdit")]
    partial class AllEdit
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.HasSequence("PersonSequence");

            modelBuilder.Entity("BeautyCenter.Models.Appointment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("ServiceId")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ServiceId");

                    b.HasIndex("EmployeeId", "ServiceId");

                    b.HasIndex("UserID", "ServiceId");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("BeautyCenter.Models.Center", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CloseTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OpenTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Centers");
                });

            modelBuilder.Entity("BeautyCenter.Models.CustomerDet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CustomerDetails")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("IdSepacificEmployee")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdSepacificEmployee");

                    b.ToTable("CustomerDets");
                });

            modelBuilder.Entity("BeautyCenter.Models.Favorite", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int?>("EmployeeId2")
                        .HasColumnType("int");

                    b.Property<int?>("ManagerId")
                        .HasColumnType("int");

                    b.Property<int?>("ServiceId")
                        .HasColumnType("int");

                    b.Property<int?>("UserID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("EmployeeId2");

                    b.HasIndex("ManagerId");

                    b.HasIndex("ServiceId");

                    b.HasIndex("UserID");

                    b.ToTable("Favorites");
                });

            modelBuilder.Entity("BeautyCenter.Models.Gallery", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.HasKey("Id");

                    b.ToTable("Galleries");
                });

            modelBuilder.Entity("BeautyCenter.Models.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("GalleryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("URL")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GalleryId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("BeautyCenter.Models.Notification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeviceToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ServiceId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Topic")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ServiceId");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("BeautyCenter.Models.Offers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int?>("IdSerivce")
                        .HasColumnType("int");

                    b.Property<int?>("ManagerId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("IdSerivce");

                    b.HasIndex("ManagerId");

                    b.HasIndex("UserId");

                    b.ToTable("Offers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Offers");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("BeautyCenter.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("NEXT VALUE FOR [PersonSequence]");

                    SqlServerPropertyBuilderExtensions.UseSequence(b.Property<int>("Id"));

                    b.Property<int?>("CenterId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("GalleryId")
                        .HasColumnType("int");

                    b.Property<string>("ImageURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Points")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GalleryId");

                    b.ToTable("People");

                    b.UseTpcMappingStrategy();
                });

            modelBuilder.Entity("BeautyCenter.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("Like")
                        .HasColumnType("int");

                    b.Property<string>("Reviews")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ServiceId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("ServiceId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("BeautyCenter.Models.Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CustomerDetId")
                        .HasColumnType("int");

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ManagerId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("TopServic")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("details")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerDetId");

                    b.HasIndex("ManagerId");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("BeautyCenter.Models.ServiceEmployee", b =>
                {
                    b.Property<int>("ServiceId")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.HasKey("ServiceId", "EmployeeId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("ServiceEmployees");
                });

            modelBuilder.Entity("BeautyCenter.Models.TimeModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("EmployyId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmployyId");

                    b.ToTable("TimeModels");
                });

            modelBuilder.Entity("BeautyCenter.Models.Package", b =>
                {
                    b.HasBaseType("BeautyCenter.Models.Offers");

                    b.HasDiscriminator().HasValue("Package");
                });

            modelBuilder.Entity("BeautyCenter.Models.Employee", b =>
                {
                    b.HasBaseType("BeautyCenter.Models.Person");

                    b.Property<string>("Exp")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rate")
                        .HasColumnType("int");

                    b.Property<int>("TotlaRate")
                        .HasColumnType("int");

                    b.HasIndex("CenterId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("BeautyCenter.Models.Manager", b =>
                {
                    b.HasBaseType("BeautyCenter.Models.Person");

                    b.HasIndex("CenterId");

                    b.ToTable("Managers");
                });

            modelBuilder.Entity("BeautyCenter.Models.User", b =>
                {
                    b.HasBaseType("BeautyCenter.Models.Person");

                    b.HasIndex("CenterId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BeautyCenter.Models.Appointment", b =>
                {
                    b.HasOne("BeautyCenter.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("BeautyCenter.Models.Service", "Service")
                        .WithMany()
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("BeautyCenter.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Employee");

                    b.Navigation("Service");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BeautyCenter.Models.CustomerDet", b =>
                {
                    b.HasOne("BeautyCenter.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("IdSepacificEmployee");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("BeautyCenter.Models.Favorite", b =>
                {
                    b.HasOne("BeautyCenter.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId");

                    b.HasOne("BeautyCenter.Models.Employee", null)
                        .WithMany("Favorites")
                        .HasForeignKey("EmployeeId2")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BeautyCenter.Models.Manager", null)
                        .WithMany("Favorites")
                        .HasForeignKey("ManagerId");

                    b.HasOne("BeautyCenter.Models.Service", "Service")
                        .WithMany()
                        .HasForeignKey("ServiceId");

                    b.HasOne("BeautyCenter.Models.User", "User")
                        .WithMany("Favorites")
                        .HasForeignKey("UserID");

                    b.Navigation("Employee");

                    b.Navigation("Service");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BeautyCenter.Models.Image", b =>
                {
                    b.HasOne("BeautyCenter.Models.Gallery", "Gallery")
                        .WithMany("Images")
                        .HasForeignKey("GalleryId");

                    b.Navigation("Gallery");
                });

            modelBuilder.Entity("BeautyCenter.Models.Notification", b =>
                {
                    b.HasOne("BeautyCenter.Models.Service", "Service")
                        .WithMany()
                        .HasForeignKey("ServiceId");

                    b.Navigation("Service");
                });

            modelBuilder.Entity("BeautyCenter.Models.Offers", b =>
                {
                    b.HasOne("BeautyCenter.Models.Employee", null)
                        .WithMany("Offers")
                        .HasForeignKey("EmployeeId");

                    b.HasOne("BeautyCenter.Models.Service", "Service")
                        .WithMany()
                        .HasForeignKey("IdSerivce");

                    b.HasOne("BeautyCenter.Models.Manager", null)
                        .WithMany("Offers")
                        .HasForeignKey("ManagerId");

                    b.HasOne("BeautyCenter.Models.User", "User")
                        .WithMany("Offers")
                        .HasForeignKey("UserId");

                    b.Navigation("Service");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BeautyCenter.Models.Person", b =>
                {
                    b.HasOne("BeautyCenter.Models.Gallery", "Gallery")
                        .WithMany()
                        .HasForeignKey("GalleryId");

                    b.Navigation("Gallery");
                });

            modelBuilder.Entity("BeautyCenter.Models.Review", b =>
                {
                    b.HasOne("BeautyCenter.Models.Employee", "Employee")
                        .WithMany("Reviews")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BeautyCenter.Models.Service", "Service")
                        .WithMany("Reviews")
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Service");
                });

            modelBuilder.Entity("BeautyCenter.Models.Service", b =>
                {
                    b.HasOne("BeautyCenter.Models.CustomerDet", "CustomerDet")
                        .WithMany()
                        .HasForeignKey("CustomerDetId");

                    b.HasOne("BeautyCenter.Models.Manager", null)
                        .WithMany("ServicesOffers")
                        .HasForeignKey("ManagerId");

                    b.Navigation("CustomerDet");
                });

            modelBuilder.Entity("BeautyCenter.Models.ServiceEmployee", b =>
                {
                    b.HasOne("BeautyCenter.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("BeautyCenter.Models.Service", "Service")
                        .WithMany()
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Service");
                });

            modelBuilder.Entity("BeautyCenter.Models.TimeModel", b =>
                {
                    b.HasOne("BeautyCenter.Models.Employee", "Employee")
                        .WithMany("DateTime")
                        .HasForeignKey("EmployyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("BeautyCenter.Models.Employee", b =>
                {
                    b.HasOne("BeautyCenter.Models.Center", "Center")
                        .WithMany("Employees")
                        .HasForeignKey("CenterId");

                    b.Navigation("Center");
                });

            modelBuilder.Entity("BeautyCenter.Models.Manager", b =>
                {
                    b.HasOne("BeautyCenter.Models.Center", "Center")
                        .WithMany()
                        .HasForeignKey("CenterId");

                    b.Navigation("Center");
                });

            modelBuilder.Entity("BeautyCenter.Models.User", b =>
                {
                    b.HasOne("BeautyCenter.Models.Center", "Center")
                        .WithMany("Users")
                        .HasForeignKey("CenterId");

                    b.Navigation("Center");
                });

            modelBuilder.Entity("BeautyCenter.Models.Center", b =>
                {
                    b.Navigation("Employees");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("BeautyCenter.Models.Gallery", b =>
                {
                    b.Navigation("Images");
                });

            modelBuilder.Entity("BeautyCenter.Models.Service", b =>
                {
                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("BeautyCenter.Models.Employee", b =>
                {
                    b.Navigation("DateTime");

                    b.Navigation("Favorites");

                    b.Navigation("Offers");

                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("BeautyCenter.Models.Manager", b =>
                {
                    b.Navigation("Favorites");

                    b.Navigation("Offers");

                    b.Navigation("ServicesOffers");
                });

            modelBuilder.Entity("BeautyCenter.Models.User", b =>
                {
                    b.Navigation("Favorites");

                    b.Navigation("Offers");
                });
#pragma warning restore 612, 618
        }
    }
}
