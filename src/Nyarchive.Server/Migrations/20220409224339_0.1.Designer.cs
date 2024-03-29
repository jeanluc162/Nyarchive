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
    [Migration("20220409224339_0.1")]
    partial class _01
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

                    b.HasKey("Id");

                    b.HasIndex("LabelId");

                    b.HasIndex("LanguageId");

                    b.ToTable("Translations");
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
                        .WithMany("articleTransactionRemoves")
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
                        .WithMany("Unit")
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
                    b.Navigation("articleTransactionRemoves");
                });

            modelBuilder.Entity("Nyarchive.Server.Model.Label", b =>
                {
                    b.Navigation("Articles");

                    b.Navigation("Products");

                    b.Navigation("Translations");

                    b.Navigation("Unit");
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
