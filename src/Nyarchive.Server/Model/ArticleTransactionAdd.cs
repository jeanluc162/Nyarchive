using System.ComponentModel.DataAnnotations;

namespace Nyarchive.Server.Model
{
    public class ArticleTransactionAdd:BaseEntity
    {
        [Required]
        public DateTime Timestamp { get; set; }
        [Required]
        public Article Article { get; set; }
        public String Tag { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public ICollection<ArticleTransactionRemove> ArticleTransactionRemoves { get; set; }
    }
}
