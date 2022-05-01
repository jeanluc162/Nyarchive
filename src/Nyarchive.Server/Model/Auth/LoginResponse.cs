using System.ComponentModel.DataAnnotations.Schema;

namespace Nyarchive.Server.Model.Auth
{
    [NotMapped]
    public class LoginResponse
    {
        public string token { get; set; }
        public DateTime expiration { get; set; }
    }
}
