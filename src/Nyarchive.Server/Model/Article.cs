using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Nyarchive.Server.Model
{
    [Index(nameof(Barcode), IsUnique = true)]
    public class Article:BaseEntity
    {
        public Byte[] Barcode { get; set; }
        [Required]
        public Label Name { get; set; }       
        [Required]
        public Unit Unit { get; set; }
        [Required]
        public Decimal QuantityOfUnit { get; set; }
        [Required]
        public Product Product { get; set; }
        public ICollection<AssignedNutritionalValue> AssignedNutritionalValues { get; set; }
        public ICollection<ArticleTransactionAdd> ArticleTransactionAdds { get; set; }
    }
}
