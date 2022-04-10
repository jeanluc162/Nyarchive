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
    [Migration("20220410150010_0.1.7_SeedDataTest")]
    partial class _017_SeedDataTest
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

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
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("ArticleId");

                    b.ToTable("ArticleTransactionAdds");
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
