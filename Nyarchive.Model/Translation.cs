using System.ComponentModel.DataAnnotations.Schema;

namespace Nyarchive.Model
{
    public class Translation:BaseEntity
    {
        public Guid LabelId {get;set;}
        public Guid LanguageId {get;set;}
        [ForeignKey(nameof(LabelId))]
        public Label Label {get;set;}
        [ForeignKey(nameof(LanguageId))]
        public Language Language {get;set;}
    }
}