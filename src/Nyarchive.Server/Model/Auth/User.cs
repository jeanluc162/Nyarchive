using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Nyarchive.Server.Model.Auth
{
    [Index(nameof(UserName), IsUnique = true)]
    public class User : IdentityUser<Guid>
    {
        [Required]
        public String UserName { get; set; }
    }
}
