using Microsoft.EntityFrameworkCore;

namespace Nyarchive.Server.Model
{
    public class NyarchiveDbContext:DbContext
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
            modelBuilder.Entity<Language>()
                .HasData(
                    new Language { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), Name = "English" },
                    new Language { Id = Guid.Parse("00000000-0000-0000-0000-000000000002"), Name = "Deutsch" }
                );

            modelBuilder.Entity<Label>()
                .HasData(
                    new Label { Id = Guid.Parse("00000000-0000-0000-0000-000000000001") }
                );

            modelBuilder.Entity<Translation>()
                .HasData(
                    new
                    {
                        Id = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                        LabelId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                        LanguageId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                        Text = "kilocalories"
                    },
                    new
                    {
                        Id = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                        LabelId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                        LanguageId = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                        Text = "Kilokalorien"
                    }
                );

            modelBuilder.Entity<Unit>()
                .HasData(
                    new
                    {
                        Id = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                        NameId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                        Symbol = "kcal"
                    }
                );
        }
    }
}