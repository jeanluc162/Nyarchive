﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Nyarchive.Server.Model;

#nullable disable

namespace Nyarchive.Server.Migrations
{
    [DbContext(typeof(NyarchiveDbContext))]
    [Migration("20220429173853_0.1.22_Identity_NewRolesAndAdminUserRoleMemberships")]
    partial class _0122_Identity_NewRolesAndAdminUserRoleMemberships
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Nyarchive.Server.Model.Article", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<byte[]>("Barcode")
                        .IsRequired()
                        .HasColumnType("varbinary(3072)");

                    b.Property<Guid>("NameId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("char(36)");

                    b.Property<decimal>("QuantityOfUnit")
                        .HasColumnType("decimal(65,30)");

                    b.Property<Guid>("UnitId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("Barcode")
                        .IsUnique();

                    b.HasIndex("NameId");

                    b.HasIndex("ProductId");

                    b.HasIndex("UnitId");

                    b.ToTable("Articles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000001"),
                            Barcode = new byte[] { 6, 9, 4, 2, 0 },
                            NameId = new Guid("00000000-0000-0000-0000-000000000004"),
                            ProductId = new Guid("00000000-0000-0000-0000-000000000001"),
                            QuantityOfUnit = 500m,
                            UnitId = new Guid("00000000-0000-0000-0000-000000000002")
                        });
                });

            modelBuilder.Entity("Nyarchive.Server.Model.ArticleTransactionAdd", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("ArticleId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("ExpirationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Tag")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("ArticleId");

                    b.ToTable("ArticleTransactionAdds");

                    b.HasData(
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000001"),
                            ArticleId = new Guid("00000000-0000-0000-0000-000000000001"),
                            ExpirationDate = new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Tag = "",
                            Timestamp = new DateTime(2022, 4, 10, 16, 30, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Nyarchive.Server.Model.ArticleTransactionRemove", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("ArticleTransactionAddId")
                        .HasColumnType("char(36)");

                    b.Property<decimal>("QuantityOfUnit")
                        .HasColumnType("decimal(65,30)");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("UnitId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("ArticleTransactionAddId");

                    b.HasIndex("UnitId");

                    b.ToTable("ArticleTransactionRemoves");

                    b.HasData(
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000001"),
                            ArticleTransactionAddId = new Guid("00000000-0000-0000-0000-000000000001"),
                            QuantityOfUnit = 250m,
                            Timestamp = new DateTime(2022, 4, 10, 17, 45, 0, 0, DateTimeKind.Unspecified),
                            UnitId = new Guid("00000000-0000-0000-0000-000000000002")
                        });
                });

            modelBuilder.Entity("Nyarchive.Server.Model.AssignedNutritionalValue", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("ArticleId")
                        .HasColumnType("char(36)");

                    b.Property<decimal>("Quantity")
                        .HasColumnType("decimal(65,30)");

                    b.Property<Guid>("UnitId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("ArticleId");

                    b.HasIndex("UnitId");

                    b.ToTable("AssignedNutritionalValues");
                });

            modelBuilder.Entity("Nyarchive.Server.Model.Auth.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000001"),
                            ConcurrencyStamp = "a28ed0c2-dd65-4a90-ad35-c7de70be3b10",
                            Name = "ArticlesReader",
                            NormalizedName = "ARTICLESREADER"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000002"),
                            ConcurrencyStamp = "6840f653-0534-4a74-b85b-ae33fc9b6587",
                            Name = "ArticlesWriter",
                            NormalizedName = "ARTICLESWRITER"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000003"),
                            ConcurrencyStamp = "bbc3f54e-5063-4508-871c-3cb6024419dc",
                            Name = "ArticleTransactionReader",
                            NormalizedName = "ARTICLETRANSACTIONREADER"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000004"),
                            ConcurrencyStamp = "38bf595f-59d1-46dd-915b-cdbc62933532",
                            Name = "ArticleTransactionWriter",
                            NormalizedName = "ARTICLETRANSACTIONWRITER"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000005"),
                            ConcurrencyStamp = "16dfc9f1-fc2b-461e-b674-4a90a575e216",
                            Name = "AssignedNutritionalValuesReader",
                            NormalizedName = "ASSIGNEDNUTRITIONALVALUESREADER"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000006"),
                            ConcurrencyStamp = "76defc25-59af-4f5f-abdd-9ee8831d14f7",
                            Name = "AssignedNutritionalValuesWriter",
                            NormalizedName = "ASSIGNEDNUTRITIONALVALUESWRITER"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000007"),
                            ConcurrencyStamp = "7dbc669c-beca-4561-b145-c04a6af8b921",
                            Name = "LabelingReader",
                            NormalizedName = "LABELINGREADER"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000008"),
                            ConcurrencyStamp = "d5ac5bb9-3207-40ba-9331-cc0b0a7ef6e1",
                            Name = "LabelingWriter",
                            NormalizedName = "LABELINGWRITER"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000009"),
                            ConcurrencyStamp = "d364cc4a-5fde-4707-8819-5478a1928e5b",
                            Name = "LanguagesReader",
                            NormalizedName = "LANGUAGESREADER"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000010"),
                            ConcurrencyStamp = "875dd90d-9cae-45b8-b2bf-c2eb5d4bb8b9",
                            Name = "LanguagesWriter",
                            NormalizedName = "LANGUAGESWRITER"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000011"),
                            ConcurrencyStamp = "21a6dc43-6dbe-4f41-b6dc-e9caf4c1afc1",
                            Name = "ProductsReader",
                            NormalizedName = "PRODUCTSREADER"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000012"),
                            ConcurrencyStamp = "58163e4b-68bb-4551-b8ff-4cf6fc580f5c",
                            Name = "ProductsWriter",
                            NormalizedName = "PRODUCTSWRITER"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000013"),
                            ConcurrencyStamp = "95128877-621d-4c57-b774-629f3f1986a4",
                            Name = "UnitsReader",
                            NormalizedName = "UNITSREADER"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000014"),
                            ConcurrencyStamp = "bf80925c-1cae-4ff1-a05f-deb74ebe977b",
                            Name = "UnitsWriter",
                            NormalizedName = "UNITSWRITER"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000015"),
                            ConcurrencyStamp = "812a0e6a-fdd2-4363-940c-16c56f499d2d",
                            Name = "UserReader",
                            NormalizedName = "USERREADER"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000016"),
                            ConcurrencyStamp = "52f725ff-096c-4d9e-aa0f-af2b7e9c7c4b",
                            Name = "UserWriter",
                            NormalizedName = "USERWRITER"
                        });
                });

            modelBuilder.Entity("Nyarchive.Server.Model.Auth.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.HasIndex("UserName")
                        .IsUnique();

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000001"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "23fbcd4f-18e3-4a1d-b1be-eb5198720336",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAEAACcQAAAAEHakOS34LT+Cd4AQ8h5LEEa+JRTn04rF7vvYYgthYAkBsCIvIh1z8MQ1YCWgbpfWig==",
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false,
                            UserName = "admin"
                        });
                });

            modelBuilder.Entity("Nyarchive.Server.Model.Auth.UserRole", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("char(36)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = new Guid("00000000-0000-0000-0000-000000000001"),
                            RoleId = new Guid("00000000-0000-0000-0000-000000000001")
                        },
                        new
                        {
                            UserId = new Guid("00000000-0000-0000-0000-000000000001"),
                            RoleId = new Guid("00000000-0000-0000-0000-000000000002")
                        },
                        new
                        {
                            UserId = new Guid("00000000-0000-0000-0000-000000000001"),
                            RoleId = new Guid("00000000-0000-0000-0000-000000000003")
                        },
                        new
                        {
                            UserId = new Guid("00000000-0000-0000-0000-000000000001"),
                            RoleId = new Guid("00000000-0000-0000-0000-000000000004")
                        },
                        new
                        {
                            UserId = new Guid("00000000-0000-0000-0000-000000000001"),
                            RoleId = new Guid("00000000-0000-0000-0000-000000000005")
                        },
                        new
                        {
                            UserId = new Guid("00000000-0000-0000-0000-000000000001"),
                            RoleId = new Guid("00000000-0000-0000-0000-000000000006")
                        },
                        new
                        {
                            UserId = new Guid("00000000-0000-0000-0000-000000000001"),
                            RoleId = new Guid("00000000-0000-0000-0000-000000000007")
                        },
                        new
                        {
                            UserId = new Guid("00000000-0000-0000-0000-000000000001"),
                            RoleId = new Guid("00000000-0000-0000-0000-000000000008")
                        },
                        new
                        {
                            UserId = new Guid("00000000-0000-0000-0000-000000000001"),
                            RoleId = new Guid("00000000-0000-0000-0000-000000000009")
                        },
                        new
                        {
                            UserId = new Guid("00000000-0000-0000-0000-000000000001"),
                            RoleId = new Guid("00000000-0000-0000-0000-000000000010")
                        },
                        new
                        {
                            UserId = new Guid("00000000-0000-0000-0000-000000000001"),
                            RoleId = new Guid("00000000-0000-0000-0000-000000000011")
                        },
                        new
                        {
                            UserId = new Guid("00000000-0000-0000-0000-000000000001"),
                            RoleId = new Guid("00000000-0000-0000-0000-000000000012")
                        },
                        new
                        {
                            UserId = new Guid("00000000-0000-0000-0000-000000000001"),
                            RoleId = new Guid("00000000-0000-0000-0000-000000000013")
                        },
                        new
                        {
                            UserId = new Guid("00000000-0000-0000-0000-000000000001"),
                            RoleId = new Guid("00000000-0000-0000-0000-000000000014")
                        },
                        new
                        {
                            UserId = new Guid("00000000-0000-0000-0000-000000000001"),
                            RoleId = new Guid("00000000-0000-0000-0000-000000000015")
                        },
                        new
                        {
                            UserId = new Guid("00000000-0000-0000-0000-000000000001"),
                            RoleId = new Guid("00000000-0000-0000-0000-000000000016")
                        });
                });

            modelBuilder.Entity("Nyarchive.Server.Model.Label", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.ToTable("Labels");

                    b.HasData(
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000001")
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000002")
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000003")
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000004")
                        });
                });

            modelBuilder.Entity("Nyarchive.Server.Model.Language", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Languages");

                    b.HasData(
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000001"),
                            Name = "English"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000002"),
                            Name = "Deutsch"
                        });
                });

            modelBuilder.Entity("Nyarchive.Server.Model.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("NameId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("NameId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000001"),
                            NameId = new Guid("00000000-0000-0000-0000-000000000003")
                        });
                });

            modelBuilder.Entity("Nyarchive.Server.Model.Translation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("LabelId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("LanguageId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("LabelId");

                    b.HasIndex("LanguageId");

                    b.ToTable("Translations");

                    b.HasData(
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000001"),
                            LabelId = new Guid("00000000-0000-0000-0000-000000000001"),
                            LanguageId = new Guid("00000000-0000-0000-0000-000000000001"),
                            Text = "kilocalories"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000002"),
                            LabelId = new Guid("00000000-0000-0000-0000-000000000001"),
                            LanguageId = new Guid("00000000-0000-0000-0000-000000000002"),
                            Text = "Kilokalorien"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000003"),
                            LabelId = new Guid("00000000-0000-0000-0000-000000000002"),
                            LanguageId = new Guid("00000000-0000-0000-0000-000000000001"),
                            Text = "gramm"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000004"),
                            LabelId = new Guid("00000000-0000-0000-0000-000000000002"),
                            LanguageId = new Guid("00000000-0000-0000-0000-000000000002"),
                            Text = "Gramm"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000005"),
                            LabelId = new Guid("00000000-0000-0000-0000-000000000003"),
                            LanguageId = new Guid("00000000-0000-0000-0000-000000000001"),
                            Text = "Flour"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000006"),
                            LabelId = new Guid("00000000-0000-0000-0000-000000000003"),
                            LanguageId = new Guid("00000000-0000-0000-0000-000000000002"),
                            Text = "Mehl"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000007"),
                            LabelId = new Guid("00000000-0000-0000-0000-000000000004"),
                            LanguageId = new Guid("00000000-0000-0000-0000-000000000001"),
                            Text = "JA! Flour"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000008"),
                            LabelId = new Guid("00000000-0000-0000-0000-000000000004"),
                            LanguageId = new Guid("00000000-0000-0000-0000-000000000002"),
                            Text = "JA! Mehl"
                        });
                });

            modelBuilder.Entity("Nyarchive.Server.Model.Unit", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("NameId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Symbol")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("NameId");

                    b.HasIndex("Symbol")
                        .IsUnique();

                    b.ToTable("Units");

                    b.HasData(
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000001"),
                            NameId = new Guid("00000000-0000-0000-0000-000000000001"),
                            Symbol = "kcal"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000002"),
                            NameId = new Guid("00000000-0000-0000-0000-000000000002"),
                            Symbol = "g"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("Nyarchive.Server.Model.Auth.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("Nyarchive.Server.Model.Auth.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("Nyarchive.Server.Model.Auth.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("Nyarchive.Server.Model.Auth.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Nyarchive.Server.Model.Article", b =>
                {
                    b.HasOne("Nyarchive.Server.Model.Label", "Name")
                        .WithMany("Articles")
                        .HasForeignKey("NameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Nyarchive.Server.Model.Product", "Product")
                        .WithMany("Articles")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Nyarchive.Server.Model.Unit", "Unit")
                        .WithMany("Articles")
                        .HasForeignKey("UnitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Name");

                    b.Navigation("Product");

                    b.Navigation("Unit");
                });

            modelBuilder.Entity("Nyarchive.Server.Model.ArticleTransactionAdd", b =>
                {
                    b.HasOne("Nyarchive.Server.Model.Article", "Article")
                        .WithMany("ArticleTransactionAdds")
                        .HasForeignKey("ArticleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Article");
                });

            modelBuilder.Entity("Nyarchive.Server.Model.ArticleTransactionRemove", b =>
                {
                    b.HasOne("Nyarchive.Server.Model.ArticleTransactionAdd", "ArticleTransactionAdd")
                        .WithMany("ArticleTransactionRemoves")
                        .HasForeignKey("ArticleTransactionAddId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Nyarchive.Server.Model.Unit", "Unit")
                        .WithMany("ArticleTransactionRemoves")
                        .HasForeignKey("UnitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ArticleTransactionAdd");

                    b.Navigation("Unit");
                });

            modelBuilder.Entity("Nyarchive.Server.Model.AssignedNutritionalValue", b =>
                {
                    b.HasOne("Nyarchive.Server.Model.Article", "Article")
                        .WithMany("AssignedNutritionalValues")
                        .HasForeignKey("ArticleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Nyarchive.Server.Model.Unit", "Unit")
                        .WithMany("AssignedNutritionalValues")
                        .HasForeignKey("UnitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Article");

                    b.Navigation("Unit");
                });

            modelBuilder.Entity("Nyarchive.Server.Model.Auth.UserRole", b =>
                {
                    b.HasOne("Nyarchive.Server.Model.Auth.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Nyarchive.Server.Model.Auth.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Nyarchive.Server.Model.Product", b =>
                {
                    b.HasOne("Nyarchive.Server.Model.Label", "Name")
                        .WithMany("Products")
                        .HasForeignKey("NameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Name");
                });

            modelBuilder.Entity("Nyarchive.Server.Model.Translation", b =>
                {
                    b.HasOne("Nyarchive.Server.Model.Label", "Label")
                        .WithMany("Translations")
                        .HasForeignKey("LabelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Nyarchive.Server.Model.Language", "Language")
                        .WithMany("Translations")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Label");

                    b.Navigation("Language");
                });

            modelBuilder.Entity("Nyarchive.Server.Model.Unit", b =>
                {
                    b.HasOne("Nyarchive.Server.Model.Label", "Name")
                        .WithMany("Units")
                        .HasForeignKey("NameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Name");
                });

            modelBuilder.Entity("Nyarchive.Server.Model.Article", b =>
                {
                    b.Navigation("ArticleTransactionAdds");

                    b.Navigation("AssignedNutritionalValues");
                });

            modelBuilder.Entity("Nyarchive.Server.Model.ArticleTransactionAdd", b =>
                {
                    b.Navigation("ArticleTransactionRemoves");
                });

            modelBuilder.Entity("Nyarchive.Server.Model.Label", b =>
                {
                    b.Navigation("Articles");

                    b.Navigation("Products");

                    b.Navigation("Translations");

                    b.Navigation("Units");
                });

            modelBuilder.Entity("Nyarchive.Server.Model.Language", b =>
                {
                    b.Navigation("Translations");
                });

            modelBuilder.Entity("Nyarchive.Server.Model.Product", b =>
                {
                    b.Navigation("Articles");
                });

            modelBuilder.Entity("Nyarchive.Server.Model.Unit", b =>
                {
                    b.Navigation("ArticleTransactionRemoves");

                    b.Navigation("Articles");

                    b.Navigation("AssignedNutritionalValues");
                });
#pragma warning restore 612, 618
        }
    }
}
