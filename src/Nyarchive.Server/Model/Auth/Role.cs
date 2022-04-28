using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nyarchive.Server.Model.Auth
{
    public class Role : IdentityRole<Guid>
    {
        [NotMapped]
        public static class RoleNames
        {
            public const String Admin = "admin";
        }
    }
}
