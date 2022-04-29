using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nyarchive.Server.Model.Auth
{
    public class Role : IdentityRole<Guid>
    {
        [NotMapped]
        public static class RoleNames
        {
            public const String ArticlesReader = nameof(ArticlesReader);
            public const String ArticlesWriter = nameof(ArticlesWriter);

            public const String ArticleTransactionReader = nameof(ArticleTransactionReader);
            public const String ArticleTransactionWriter = nameof(ArticleTransactionWriter);

            public const String AssignedNutritionalValuesReader = nameof(AssignedNutritionalValuesReader);
            public const String AssignedNutritionalValuesWriter = nameof(AssignedNutritionalValuesWriter);

            public const String LabelingReader = nameof(LabelingReader);
            public const String LabelingWriter = nameof(LabelingWriter);

            public const String LanguagesReader = nameof(LanguagesReader);
            public const String LanguagesWriter = nameof(LanguagesWriter);

            public const String ProductsReader = nameof(ProductsReader);
            public const String ProductsWriter = nameof(ProductsWriter);

            public const String UnitsReader = nameof(UnitsReader);
            public const String UnitsWriter = nameof(UnitsWriter);

            public const String UserReader = nameof(UserReader);
            public const String UserWriter = nameof(UserWriter);
        }
    }
}
