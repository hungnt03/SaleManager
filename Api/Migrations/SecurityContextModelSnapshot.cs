﻿// <auto-generated />
using System;
using Api.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Api.Migrations
{
    [DbContext(typeof(SecurityContext))]
    partial class SecurityContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Api.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2020, 7, 10, 9, 39, 16, 38, DateTimeKind.Local).AddTicks(3993),
                            CreatedBy = "administrator",
                            Description = "Các loại hàng về Thực phẩm",
                            Name = "Thực phẩm"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2020, 7, 10, 9, 39, 16, 39, DateTimeKind.Local).AddTicks(9686),
                            CreatedBy = "administrator",
                            Description = "Các loại hàng về Rượu bia",
                            Name = "Rượu bia"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2020, 7, 10, 9, 39, 16, 39, DateTimeKind.Local).AddTicks(9714),
                            CreatedBy = "administrator",
                            Description = "Các loại hàng về Thuốc lá",
                            Name = "Thuốc lá"
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2020, 7, 10, 9, 39, 16, 39, DateTimeKind.Local).AddTicks(9716),
                            CreatedBy = "administrator",
                            Description = "Các loại hàng về Mỹ phẩm",
                            Name = "Mỹ phẩm"
                        });
                });

            modelBuilder.Entity("Api.Entities.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("Contact")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.ToTable("Customer");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "11b Cát Linh, Quốc Tử Giám, Đống Đa, Hà Nội",
                            Contact = "02438267984",
                            CreatedAt = new DateTime(2020, 7, 10, 9, 39, 16, 41, DateTimeKind.Local).AddTicks(3281),
                            CreatedBy = "administrator",
                            Name = "Nguyễn Hữu Hoà"
                        },
                        new
                        {
                            Id = 2,
                            Address = "59 Quang Trung, Nguyễn Du, Hai Bà Trưng, Hà Nội",
                            Contact = "02438226676",
                            CreatedAt = new DateTime(2020, 7, 10, 9, 39, 16, 41, DateTimeKind.Local).AddTicks(3347),
                            CreatedBy = "administrator",
                            Name = "Trần Danh Mạnh"
                        },
                        new
                        {
                            Id = 3,
                            Address = "35 Lô 1A, đường, Trung Yên 11B, Trung Hoà, Cầu Giấy, Hà Nội",
                            Contact = "02436230311",
                            CreatedAt = new DateTime(2020, 7, 10, 9, 39, 16, 41, DateTimeKind.Local).AddTicks(3349),
                            CreatedBy = "administrator",
                            Name = "Hoàng Tố Như"
                        });
                });

            modelBuilder.Entity("Api.Entities.Discount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Barcode")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.ToTable("Discount");
                });

            modelBuilder.Entity("Api.Entities.Product", b =>
                {
                    b.Property<string>("Barcode")
                        .HasColumnType("nvarchar(16)")
                        .HasMaxLength(16);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("Enable")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ExpirationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<bool?>("Pin")
                        .HasColumnType("bit");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("SupplierId")
                        .HasColumnType("int");

                    b.Property<string>("Unit")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Barcode");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            Barcode = "3110354325000",
                            CategoryId = 3,
                            CreatedAt = new DateTime(2020, 7, 10, 9, 39, 16, 41, DateTimeKind.Local).AddTicks(8435),
                            CreatedBy = "administrator",
                            Enable = true,
                            ExpirationDate = new DateTime(2022, 3, 10, 9, 39, 16, 41, DateTimeKind.Local).AddTicks(5131),
                            Img = "",
                            Name = "Thuốc lá Thăng Long",
                            Pin = false,
                            Price = 10000,
                            Quantity = 63,
                            SupplierId = 1,
                            Unit = "Bao"
                        },
                        new
                        {
                            Barcode = "8004800008152",
                            CategoryId = 1,
                            CreatedAt = new DateTime(2020, 7, 10, 9, 39, 16, 41, DateTimeKind.Local).AddTicks(8541),
                            CreatedBy = "administrator",
                            Enable = true,
                            ExpirationDate = new DateTime(2021, 7, 10, 9, 39, 16, 41, DateTimeKind.Local).AddTicks(8475),
                            Img = "",
                            Name = "Bánh Sampa Balocco Savoiardi 200g",
                            Pin = false,
                            Price = 59000,
                            Quantity = 20,
                            SupplierId = 1,
                            Unit = "Gói"
                        },
                        new
                        {
                            Barcode = "8934637514871",
                            CategoryId = 1,
                            CreatedAt = new DateTime(2020, 7, 10, 9, 39, 16, 41, DateTimeKind.Local).AddTicks(8548),
                            CreatedBy = "administrator",
                            Enable = true,
                            ExpirationDate = new DateTime(2022, 3, 10, 9, 39, 16, 41, DateTimeKind.Local).AddTicks(8544),
                            Img = "",
                            Name = "Sốt ướp thịt nướng",
                            Pin = false,
                            Price = 16000,
                            Quantity = 30,
                            SupplierId = 1,
                            Unit = "Gói"
                        },
                        new
                        {
                            Barcode = "8934752060109",
                            CategoryId = 1,
                            CreatedAt = new DateTime(2020, 7, 10, 9, 39, 16, 41, DateTimeKind.Local).AddTicks(8552),
                            CreatedBy = "administrator",
                            Enable = true,
                            ExpirationDate = new DateTime(2022, 3, 10, 9, 39, 16, 41, DateTimeKind.Local).AddTicks(8550),
                            Img = "",
                            Name = "Dấm trung thành 500ml",
                            Pin = false,
                            Price = 10400,
                            Quantity = 50,
                            SupplierId = 1,
                            Unit = "Chai"
                        },
                        new
                        {
                            Barcode = "8934804004044",
                            CategoryId = 1,
                            CreatedAt = new DateTime(2020, 7, 10, 9, 39, 16, 41, DateTimeKind.Local).AddTicks(8555),
                            CreatedBy = "administrator",
                            Enable = true,
                            ExpirationDate = new DateTime(2022, 3, 10, 9, 39, 16, 41, DateTimeKind.Local).AddTicks(8553),
                            Img = "",
                            Name = "Dầu hào 350g",
                            Pin = false,
                            Price = 21000,
                            Quantity = 30,
                            SupplierId = 2,
                            Unit = "Chai"
                        },
                        new
                        {
                            Barcode = "8934988021028",
                            CategoryId = 1,
                            CreatedAt = new DateTime(2020, 7, 10, 9, 39, 16, 41, DateTimeKind.Local).AddTicks(8558),
                            CreatedBy = "administrator",
                            Enable = true,
                            ExpirationDate = new DateTime(2022, 3, 10, 9, 39, 16, 41, DateTimeKind.Local).AddTicks(8556),
                            Img = "",
                            Name = "Dầu ăn simply 2l",
                            Pin = false,
                            Price = 130000,
                            Quantity = 10,
                            SupplierId = 2,
                            Unit = "Chai"
                        },
                        new
                        {
                            Barcode = "8935009922225",
                            CategoryId = 1,
                            CreatedAt = new DateTime(2020, 7, 10, 9, 39, 16, 41, DateTimeKind.Local).AddTicks(8562),
                            CreatedBy = "administrator",
                            Enable = true,
                            ExpirationDate = new DateTime(2022, 3, 10, 9, 39, 16, 41, DateTimeKind.Local).AddTicks(8559),
                            Img = "",
                            Name = "Kẹo gấu thiên hồng 1kg",
                            Pin = false,
                            Price = 95000,
                            Quantity = 15,
                            SupplierId = 1,
                            Unit = "Gói"
                        },
                        new
                        {
                            Barcode = "8936017364113",
                            CategoryId = 1,
                            CreatedAt = new DateTime(2020, 7, 10, 9, 39, 16, 41, DateTimeKind.Local).AddTicks(8565),
                            CreatedBy = "administrator",
                            Enable = true,
                            ExpirationDate = new DateTime(2022, 3, 10, 9, 39, 16, 41, DateTimeKind.Local).AddTicks(8563),
                            Img = "",
                            Name = "Nước mắm Cá cốt ABC",
                            Pin = false,
                            Price = 12000,
                            Quantity = 15,
                            SupplierId = 2,
                            Unit = "Chai"
                        },
                        new
                        {
                            Barcode = "8936017367046",
                            CategoryId = 1,
                            CreatedAt = new DateTime(2020, 7, 10, 9, 39, 16, 41, DateTimeKind.Local).AddTicks(8568),
                            CreatedBy = "administrator",
                            Enable = true,
                            ExpirationDate = new DateTime(2022, 3, 10, 9, 39, 16, 41, DateTimeKind.Local).AddTicks(8566),
                            Img = "",
                            Name = "Tương cà chinsu 250g",
                            Pin = false,
                            Price = 12000,
                            Quantity = 50,
                            SupplierId = 1,
                            Unit = "Chai"
                        },
                        new
                        {
                            Barcode = "8936028040426",
                            CategoryId = 1,
                            CreatedAt = new DateTime(2020, 7, 10, 9, 39, 16, 41, DateTimeKind.Local).AddTicks(8571),
                            CreatedBy = "administrator",
                            Enable = true,
                            ExpirationDate = new DateTime(2022, 3, 10, 9, 39, 16, 41, DateTimeKind.Local).AddTicks(8569),
                            Img = "",
                            Name = "Sốt gia vị chinsu",
                            Pin = false,
                            Price = 15000,
                            Quantity = 100,
                            SupplierId = 1,
                            Unit = "Gói"
                        },
                        new
                        {
                            Barcode = "8936124472008",
                            CategoryId = 1,
                            CreatedAt = new DateTime(2020, 7, 10, 9, 39, 16, 41, DateTimeKind.Local).AddTicks(8574),
                            CreatedBy = "administrator",
                            Enable = true,
                            ExpirationDate = new DateTime(2022, 3, 10, 9, 39, 16, 41, DateTimeKind.Local).AddTicks(8572),
                            Img = "",
                            Name = "Đậu phộng nước cốt dừa Tân Tân gói 75g",
                            Pin = false,
                            Price = 10000,
                            Quantity = 30,
                            SupplierId = 1,
                            Unit = "Gói"
                        },
                        new
                        {
                            Barcode = "8938503112147",
                            CategoryId = 1,
                            CreatedAt = new DateTime(2020, 7, 10, 9, 39, 16, 41, DateTimeKind.Local).AddTicks(8578),
                            CreatedBy = "administrator",
                            Enable = true,
                            ExpirationDate = new DateTime(2022, 3, 10, 9, 39, 16, 41, DateTimeKind.Local).AddTicks(8575),
                            Img = "",
                            Name = "Mít sấy Vinamit gói 500g",
                            Pin = false,
                            Price = 143600,
                            Quantity = 20,
                            SupplierId = 1,
                            Unit = "Gói"
                        });
                });

            modelBuilder.Entity("Api.Entities.Supplier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("Contact1")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("Contact2")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.ToTable("Supplier");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "183 Hoàng Hoa Thám, Ngọc Hồ, Ba Đình, Hà Nội",
                            Contact1 = "02437281476",
                            CreatedAt = new DateTime(2020, 7, 10, 9, 39, 16, 42, DateTimeKind.Local).AddTicks(751),
                            CreatedBy = "administrator",
                            Name = "Nguyễn Thị Thuỷ(bibica)"
                        },
                        new
                        {
                            Id = 2,
                            Address = "25 Văn Miếu, Đống Đa, Hà Nội, Vietnam",
                            CreatedAt = new DateTime(2020, 7, 10, 9, 39, 16, 42, DateTimeKind.Local).AddTicks(758),
                            CreatedBy = "administrator",
                            Name = "Nguyễn Đức Cảnh(ĐL cấp 1)"
                        });
                });

            modelBuilder.Entity("Api.Entities.Transaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("BillNumber")
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<bool>("IsPayment")
                        .HasColumnType("bit");

                    b.Property<decimal>("PayBack")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Payment")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("SuplierId")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.ToTable("Transaction");
                });

            modelBuilder.Entity("Api.Entities.TransactionDetail", b =>
                {
                    b.Property<string>("Barcode")
                        .HasColumnType("nvarchar(12)")
                        .HasMaxLength(12);

                    b.Property<int>("TracsactionId")
                        .HasColumnType("int");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("IsPayment")
                        .HasColumnType("bit");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("SuplierId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Barcode", "TracsactionId");

                    b.ToTable("TransactionDetail");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
