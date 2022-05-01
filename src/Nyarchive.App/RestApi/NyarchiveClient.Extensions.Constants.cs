using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nyarchive.App.RestApi
{
    public partial class NyarchiveClient
    {
        protected static class PreferencesFields
        {
            private const String Prefix = "NyarchiveRestApi:";
            public const String BaseUrl = Prefix + nameof(BaseUrl);
            public const String Token = Prefix + nameof(Token);
            public const String TokenValidUntil = Prefix + nameof(TokenValidUntil);
        }
    }
}
