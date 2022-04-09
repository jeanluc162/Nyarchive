using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nyarchive.Server.Model
{
    public class Translation:BaseEntity
    {
        [Required]
        public Label Label {get;set;}
        [Required]
        public Language Language {get;set;}
    }
}