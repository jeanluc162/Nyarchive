using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Nyarchive.Server.Model
{
    public class Product:BaseEntity
    {
        [Required]
        public Label Name { get; set; }
        public ICollection<Article> Articles { get; set; }
    }
}
