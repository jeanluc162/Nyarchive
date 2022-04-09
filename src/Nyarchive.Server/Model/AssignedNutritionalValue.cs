using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Nyarchive.Server.Model
{
    public class AssignedNutritionalValue:BaseEntity
    {
        [Required]
        public Unit Unit { get; set; }
        [Required]
        public Article Article { get; set; }
        [Required]
        public Decimal Quantity { get; set; }
    }
}
