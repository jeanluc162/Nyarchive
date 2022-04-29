using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Nyarchive.Server.Model.Auth;

namespace Nyarchive.Server.Model
{
    public class NyarchiveDbContext: IdentityDbContext<User, Role, Guid, IdentityUserClaim<Guid>, UserRole, IdentityUserLogin<Guid>, IdentityRoleClaim<Guid>, IdentityUserToken<Guid>>
    {
        public DbSet<Article> Articles { get; set; }
        public DbSet<ArticleTransactionAdd> ArticleTransactionAdds { get; set; }
        public DbSet<ArticleTransactionRemove> ArticleTransactionRemoves { get; set; }
        public DbSet<AssignedNutritionalValue> AssignedNutritionalValues { get; set; }
        public DbSet<Label> Labels { get; set; }
        public DbSet<Language> Languages {get;set;}
        public DbSet<Product> Products { get; set; }
        public DbSet<Translation> Translations {get;set;}
        public DbSet<Unit> Units {get;set;}
        public NyarchiveDbContext(DbContextOptions<NyarchiveDbContext> options) : base(options){ }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            #region Master Data
            modelBuilder.Entity<Language>()
                .HasData(
                    new Language { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), Name = "English" },
                    new Language { Id = Guid.Parse("00000000-0000-0000-0000-000000000002"), Name = "Deutsch" }
                );

            modelBuilder.Entity<Label>()
                .HasData(
                    new Label { Id = Guid.Parse("00000000-0000-0000-0000-000000000001") }, //Unit: Kilokalorien
                    new Label { Id = Guid.Parse("00000000-0000-0000-0000-000000000002") }, //Unit: Gramm
                    new Label { Id = Guid.Parse("00000000-0000-0000-0000-000000000003") }, //Product: Mehl
                    new Label { Id = Guid.Parse("00000000-0000-0000-0000-000000000004") } //Article: JA! Mehl
                );

            modelBuilder.Entity<Translation>()
                .HasData(
                    new //Unit: Kilokalorien: Englisch
                    {
                        Id = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                        LabelId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                        LanguageId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                        Text = "kilocalories"
                    },
                    new //Unit: Kilokalorien: Deutsch
                    {
                        Id = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                        LabelId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                        LanguageId = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                        Text = "Kilokalorien"
                    },
                    new //Unit: Gramm: Englisch
                    {
                        Id = Guid.Parse("00000000-0000-0000-0000-000000000003"),
                        LabelId = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                        LanguageId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                        Text = "gramm"
                    },
                    new //Unit: Gramm: Deutsch
                    {
                        Id = Guid.Parse("00000000-0000-0000-0000-000000000004"),
                        LabelId = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                        LanguageId = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                        Text = "Gramm"
                    },
                    new //Product: Mehl: Englisch
                    {
                        Id = Guid.Parse("00000000-0000-0000-0000-000000000005"),
                        LabelId = Guid.Parse("00000000-0000-0000-0000-000000000003"),
                        LanguageId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                        Text = "Flour"
                    },
                    new //Product: Mehl: Deutsch
                    {
                        Id = Guid.Parse("00000000-0000-0000-0000-000000000006"),
                        LabelId = Guid.Parse("00000000-0000-0000-0000-000000000003"),
                        LanguageId = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                        Text = "Mehl"
                    },
                    new //Article: JA! Mehl: Englisch
                    {
                        Id = Guid.Parse("00000000-0000-0000-0000-000000000007"),
                        LabelId = Guid.Parse("00000000-0000-0000-0000-000000000004"),
                        LanguageId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                        Text = "JA! Flour"
                    },
                    new //Article: JA! Mehl: Deutsch
                    {
                        Id = Guid.Parse("00000000-0000-0000-0000-000000000008"),
                        LabelId = Guid.Parse("00000000-0000-0000-0000-000000000004"),
                        LanguageId = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                        Text = "JA! Mehl"
                    }
                );

            modelBuilder.Entity<Unit>()
                .HasData(
                    new //Kilokalorien
                    {
                        Id = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                        NameId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                        Symbol = "kcal"
                    },
                    new //Gramm
                    {
                        Id = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                        NameId = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                        Symbol = "g"
                    }
                );

            modelBuilder.Entity<Product>()
                .HasData(
                    new //Mehl
                    {
                        Id = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                        NameId = Guid.Parse("00000000-0000-0000-0000-000000000003")
                    }
                );

            modelBuilder.Entity<Article>()
                .HasData(
                    new //JA! Mehl
                    {
                        Id = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                        Barcode = new Byte[] { 6, 9, 4, 2, 0 },
                        NameId = Guid.Parse("00000000-0000-0000-0000-000000000004"),
                        UnitId = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                        QuantityOfUnit = (Decimal)500.0,
                        ProductId = Guid.Parse("00000000-0000-0000-0000-000000000001")
                    }
                );

            modelBuilder.Entity<ArticleTransactionAdd>()
                .HasData(
                    new //Einkauf von JA! Mehl
                    {
                        Id = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                        Timestamp = new DateTime(2022, 4, 10, 16, 30, 0),
                        ArticleId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                        ExpirationDate = new DateTime(2024, 3, 1),
                        Tag = ""
                    }
                );

            modelBuilder.Entity<ArticleTransactionRemove>()
                .HasData(
                    new //Verbrauch von 250g JA! Mehl
                    {
                        Id = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                        Timestamp = new DateTime(2022, 4, 10, 17, 45, 0),
                        ArticleTransactionAddId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                        UnitId = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                        QuantityOfUnit = (Decimal)250.0
                    }
                );
            #endregion

            #region Roles & Default User
            //admin-role
            modelBuilder.Entity<Role>().HasData(
                    new Role
                    {
                        Id = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                        Name = Role.RoleNames.ArticlesReader,
                        NormalizedName = Role.RoleNames.ArticlesReader.ToUpper()
                    },
                    new Role
                    {
                        Id = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                        Name = Role.RoleNames.ArticlesWriter,
                        NormalizedName = Role.RoleNames.ArticlesWriter.ToUpper()
                    },
                    new Role
                    {
                        Id = Guid.Parse("00000000-0000-0000-0000-000000000003"),
                        Name = Role.RoleNames.ArticleTransactionReader,
                        NormalizedName = Role.RoleNames.ArticleTransactionReader.ToUpper()
                    },
                    new Role
                    {
                        Id = Guid.Parse("00000000-0000-0000-0000-000000000004"),
                        Name = Role.RoleNames.ArticleTransactionWriter,
                        NormalizedName = Role.RoleNames.ArticleTransactionWriter.ToUpper()
                    },
                    new Role
                    {
                        Id = Guid.Parse("00000000-0000-0000-0000-000000000005"),
                        Name = Role.RoleNames.AssignedNutritionalValuesReader,
                        NormalizedName = Role.RoleNames.AssignedNutritionalValuesReader.ToUpper()
                    },
                    new Role
                    {
                        Id = Guid.Parse("00000000-0000-0000-0000-000000000006"),
                        Name = Role.RoleNames.AssignedNutritionalValuesWriter,
                        NormalizedName = Role.RoleNames.AssignedNutritionalValuesWriter.ToUpper()
                    },
                    new Role
                    {
                        Id = Guid.Parse("00000000-0000-0000-0000-000000000007"),
                        Name = Role.RoleNames.LabelingReader,
                        NormalizedName = Role.RoleNames.LabelingReader.ToUpper()
                    },
                    new Role
                    {
                        Id = Guid.Parse("00000000-0000-0000-0000-000000000008"),
                        Name = Role.RoleNames.LabelingWriter,
                        NormalizedName = Role.RoleNames.LabelingWriter.ToUpper()
                    },
                    new Role
                    {
                        Id = Guid.Parse("00000000-0000-0000-0000-000000000009"),
                        Name = Role.RoleNames.LanguagesReader,
                        NormalizedName = Role.RoleNames.LanguagesReader.ToUpper()
                    },
                    new Role
                    {
                        Id = Guid.Parse("00000000-0000-0000-0000-000000000010"),
                        Name = Role.RoleNames.LanguagesWriter,
                        NormalizedName = Role.RoleNames.LanguagesWriter.ToUpper()
                    },
                    new Role
                    {
                        Id = Guid.Parse("00000000-0000-0000-0000-000000000011"),
                        Name = Role.RoleNames.ProductsReader,
                        NormalizedName = Role.RoleNames.ProductsReader.ToUpper()
                    },
                    new Role
                    {
                        Id = Guid.Parse("00000000-0000-0000-0000-000000000012"),
                        Name = Role.RoleNames.ProductsWriter,
                        NormalizedName = Role.RoleNames.ProductsWriter.ToUpper()
                    },
                    new Role
                    {
                        Id = Guid.Parse("00000000-0000-0000-0000-000000000013"),
                        Name = Role.RoleNames.UnitsReader,
                        NormalizedName = Role.RoleNames.UnitsReader.ToUpper()
                    },
                    new Role
                    {
                        Id = Guid.Parse("00000000-0000-0000-0000-000000000014"),
                        Name = Role.RoleNames.UnitsWriter,
                        NormalizedName = Role.RoleNames.UnitsWriter.ToUpper()
                    },
                    new Role
                    {
                        Id = Guid.Parse("00000000-0000-0000-0000-000000000015"),
                        Name = Role.RoleNames.UserReader,
                        NormalizedName = Role.RoleNames.UserReader.ToUpper()
                    },
                    new Role
                    {
                        Id = Guid.Parse("00000000-0000-0000-0000-000000000016"),
                        Name = Role.RoleNames.UserWriter,
                        NormalizedName = Role.RoleNames.UserWriter.ToUpper()
                    }
                );

            //admin-user
            //default password is empty
            var PasswordHasher = new PasswordHasher<User>();
            modelBuilder.Entity<User>().HasData(
                    new User
                    {
                        Id = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                        UserName = "admin",
                        NormalizedUserName = "admin".ToUpper(),
                        PasswordHash = PasswordHasher.HashPassword(null, "admin")
                    }
                );

            //Assign the admin-role to the admin-user
            //modelBuilder.Entity<IdentityUserRole<string>>().HasKey(iur => new { iur.RoleId, iur.UserId });
            modelBuilder.Entity<UserRole>().HasData(
                new UserRole
                {
                    RoleId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    UserId = Guid.Parse("00000000-0000-0000-0000-000000000001")
                },
                new UserRole
                {
                    RoleId = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    UserId = Guid.Parse("00000000-0000-0000-0000-000000000001")
                },
                new UserRole
                {
                    RoleId = Guid.Parse("00000000-0000-0000-0000-000000000003"),
                    UserId = Guid.Parse("00000000-0000-0000-0000-000000000001")
                },
                new UserRole
                {
                    RoleId = Guid.Parse("00000000-0000-0000-0000-000000000004"),
                    UserId = Guid.Parse("00000000-0000-0000-0000-000000000001")
                },
                new UserRole
                {
                    RoleId = Guid.Parse("00000000-0000-0000-0000-000000000005"),
                    UserId = Guid.Parse("00000000-0000-0000-0000-000000000001")
                },
                new UserRole
                {
                    RoleId = Guid.Parse("00000000-0000-0000-0000-000000000006"),
                    UserId = Guid.Parse("00000000-0000-0000-0000-000000000001")
                },
                new UserRole
                {
                    RoleId = Guid.Parse("00000000-0000-0000-0000-000000000007"),
                    UserId = Guid.Parse("00000000-0000-0000-0000-000000000001")
                },
                new UserRole
                {
                    RoleId = Guid.Parse("00000000-0000-0000-0000-000000000008"),
                    UserId = Guid.Parse("00000000-0000-0000-0000-000000000001")
                },
                new UserRole
                {
                    RoleId = Guid.Parse("00000000-0000-0000-0000-000000000009"),
                    UserId = Guid.Parse("00000000-0000-0000-0000-000000000001")
                },
                new UserRole
                {
                    RoleId = Guid.Parse("00000000-0000-0000-0000-000000000010"),
                    UserId = Guid.Parse("00000000-0000-0000-0000-000000000001")
                },
                new UserRole
                {
                    RoleId = Guid.Parse("00000000-0000-0000-0000-000000000011"),
                    UserId = Guid.Parse("00000000-0000-0000-0000-000000000001")
                },
                new UserRole
                {
                    RoleId = Guid.Parse("00000000-0000-0000-0000-000000000012"),
                    UserId = Guid.Parse("00000000-0000-0000-0000-000000000001")
                },
                new UserRole
                {
                    RoleId = Guid.Parse("00000000-0000-0000-0000-000000000013"),
                    UserId = Guid.Parse("00000000-0000-0000-0000-000000000001")
                },
                new UserRole
                {
                    RoleId = Guid.Parse("00000000-0000-0000-0000-000000000014"),
                    UserId = Guid.Parse("00000000-0000-0000-0000-000000000001")
                },
                new UserRole
                {
                    RoleId = Guid.Parse("00000000-0000-0000-0000-000000000015"),
                    UserId = Guid.Parse("00000000-0000-0000-0000-000000000001")
                },
                new UserRole
                {
                    RoleId = Guid.Parse("00000000-0000-0000-0000-000000000016"),
                    UserId = Guid.Parse("00000000-0000-0000-0000-000000000001")
                }
            );
            #endregion
        }
    }
}