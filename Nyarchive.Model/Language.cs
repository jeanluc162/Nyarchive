using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nyarchive.Model
{
    [Index(nameof(Name), IsUnique = true)]
    public class Language:BaseEntity
    {
        [Required]
        public String Name {get;set;}
        [InverseProperty(nameof(Translation.LanguageId))]
        public ICollection<Translation> Translations {get;set;}
    }
}