using System.ComponentModel.DataAnnotations.Schema;

namespace Nyarchive.Server.Model
{
    public class Label:BaseEntity
    {
        //Übersetzungen
        public ICollection<Translation> Translations {get;set;}
        //Sachen die Beschriftungen brauchen
        public ICollection<Article> Articles {get;set;}
        public ICollection<Product> Products {get;set;}
        public ICollection<Unit> Unit {get;set;}
    }
}