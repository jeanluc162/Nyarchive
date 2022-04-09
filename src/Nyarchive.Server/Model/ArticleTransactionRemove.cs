using System.ComponentModel.DataAnnotations;

namespace Nyarchive.Server.Model
{
    public class ArticleTransactionRemove:BaseEntity
    {
        [Required]
        public DateTime Timestamp { get; set; }
        [Required]
        public ArticleTransactionAdd ArticleTransactionAdd { get; set; }
        [Required]
        public Unit Unit { get; set; }
        [Required]
        public Decimal QuantityOfUnit { get; set; }
    }
}
