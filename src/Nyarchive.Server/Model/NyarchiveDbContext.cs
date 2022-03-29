using Microsoft.EntityFrameworkCore;

namespace Nyarchive.Server.Model
{
    public class NyarchiveDbContext:DbContext
    {
        public DbSet<Language> Languages {get;set;}
        public DbSet<Translation> Translations {get;set;}
        public DbSet<Label> Labels {get;set;}
        public NyarchiveDbContext(DbContextOptions<NyarchiveDbContext> options) : base(options){ }
    }
}