using System.ComponentModel.DataAnnotations.Schema;

namespace Nyarchive.Server.Model
{
    public class Label:BaseEntity
    {
        [InverseProperty(nameof(Translation.LabelId))]
        public ICollection<Translation> Translations {get;set;}
    }
}