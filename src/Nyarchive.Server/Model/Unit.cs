using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Nyarchive.Server.Model
{
    [Index(nameof(Symbol), IsUnique = true)]
    public class Unit:BaseEntity
    {
        [Required]
        public Label Name { get; set; }
        [Required]
        public String Symbol { get; set; }
        public ICollection<Article> Articles { get; set; }
        public ICollection<AssignedNutritionalValue> AssignedNutritionalValues { get; set; }
        public ICollection<ArticleTransactionRemove> ArticleTransactionRemoves { get; set; }
    }
}
