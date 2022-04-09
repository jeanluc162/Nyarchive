using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nyarchive.Server.Model
{
    public class Language:BaseEntity
    {
        [Required]
        public String Name {get;set;}
        public ICollection<Translation> Translations {get;set;}
    }
}