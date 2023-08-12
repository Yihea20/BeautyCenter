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
    [Migration("20230812095050_ImageGallery")]
    partial class ImageGallery
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BeautyCenter.Models.Appontment", b =>
                {
                    b.Property<int?>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int?>("ServiceId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserID")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("EmployeeId", "ServiceId");

                    b.HasIndex("ServiceId");

                    b.HasIndex("UserID");

                    b.ToTable("Appontments");
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

            modelBuilder.Entity("BeautyCenter.Models.CostomerDet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CostomerDetails")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("IdSepacificEmployee")
                        .HasColumnType("int");

                    b.Property<byte[]>("ImageArray")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdSepacificEmployee");

                    b.ToTable("CostomerDets");
                });

            modelBuilder.Entity("BeautyCenter.Models.Favorate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int?>("ServiceId")
                        .HasColumnType("int");

                    b.Property<int?>("UserID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("ServiceId");

                    b.HasIndex("UserID");

                    b.ToTable("Favorates");
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

                    b.Property<byte[]>("ImageArray")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Name")
                        .IsRequired()
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

                    b.Property<int?>("ServiceId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
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

                    b.Property<int?>("IdSerivce")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdSerivce");

                    b.HasIndex("UserId");

                    b.ToTable("Offers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Offers");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("BeautyCenter.Models.Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CostomerDetId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("ImageArray")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("details")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CostomerDetId");

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

            modelBuilder.Entity("BeautyCenter.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CenterId")
                        .HasColumnType("int");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("GalleryId")
                        .HasColumnType("int");

                    b.Property<int?>("ImageId")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Points")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CenterId");

                    b.HasIndex("GalleryId");

                    b.HasIndex("ImageId");

                    b.ToTable("Users");

                    b.HasDiscriminator<string>("Discriminator").HasValue("User");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("BeautyCenter.Models.Package", b =>
                {
                    b.HasBaseType("BeautyCenter.Models.Offers");

                    b.HasDiscriminator().HasValue("Package");
                });

            modelBuilder.Entity("BeautyCenter.Models.Employee", b =>
                {
                    b.HasBaseType("BeautyCenter.Models.User");

                    b.Property<int?>("CenterId1")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Exp")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rate")
                        .HasColumnType("int");

                    b.Property<int>("TotlaRate")
                        .HasColumnType("int");

                    b.HasIndex("CenterId1");

                    b.HasDiscriminator().HasValue("Employee");
                });

            modelBuilder.Entity("BeautyCenter.Models.Manager", b =>
                {
                    b.HasBaseType("BeautyCenter.Models.User");

                    b.HasDiscriminator().HasValue("Manager");
                });

            modelBuilder.Entity("BeautyCenter.Models.Appontment", b =>
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

                    b.HasOne("BeautyCenter.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Service");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BeautyCenter.Models.CostomerDet", b =>
                {
                    b.HasOne("BeautyCenter.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("IdSepacificEmployee");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("BeautyCenter.Models.Favorate", b =>
                {
                    b.HasOne("BeautyCenter.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId");

                    b.HasOne("BeautyCenter.Models.Service", "Service")
                        .WithMany()
                        .HasForeignKey("ServiceId");

                    b.HasOne("BeautyCenter.Models.User", "User")
                        .WithMany("Favorates")
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
                    b.HasOne("BeautyCenter.Models.Service", "Service")
                        .WithMany()
                        .HasForeignKey("IdSerivce");

                    b.HasOne("BeautyCenter.Models.User", null)
                        .WithMany("Offers")
                        .HasForeignKey("UserId");

                    b.Navigation("Service");
                });

            modelBuilder.Entity("BeautyCenter.Models.Service", b =>
                {
                    b.HasOne("BeautyCenter.Models.CostomerDet", "CostomerDet")
                        .WithMany()
                        .HasForeignKey("CostomerDetId");

                    b.Navigation("CostomerDet");
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

            modelBuilder.Entity("BeautyCenter.Models.User", b =>
                {
                    b.HasOne("BeautyCenter.Models.Center", "Center")
                        .WithMany("Users")
                        .HasForeignKey("CenterId");

                    b.HasOne("BeautyCenter.Models.Gallery", "Gallery")
                        .WithMany()
                        .HasForeignKey("GalleryId");

                    b.HasOne("BeautyCenter.Models.Image", "Image")
                        .WithMany()
                        .HasForeignKey("ImageId");

                    b.Navigation("Center");

                    b.Navigation("Gallery");

                    b.Navigation("Image");
                });

            modelBuilder.Entity("BeautyCenter.Models.Employee", b =>
                {
                    b.HasOne("BeautyCenter.Models.Center", null)
                        .WithMany("Employees")
                        .HasForeignKey("CenterId1");
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

            modelBuilder.Entity("BeautyCenter.Models.User", b =>
                {
                    b.Navigation("Favorates");

                    b.Navigation("Offers");
                });
#pragma warning restore 612, 618
        }
    }
}
