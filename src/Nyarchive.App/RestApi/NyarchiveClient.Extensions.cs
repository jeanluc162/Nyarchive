using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nyarchive.App.RestApi
{
    public partial class NyarchiveClient
    {
        private readonly ILogger _logger;
        private readonly IPreferences _preferences;

        [ActivatorUtilitiesConstructor]
        public NyarchiveClient(System.Net.Http.HttpClient httpClient, ILogger<NyarchiveClient> logger, IPreferences preferences) : this(null, httpClient)
        {
            _logger = logger;
            _preferences = preferences;
        }
        public String BaseUrl
        {
            get
            {
                return _preferences.Get<String>(PreferencesFields.BaseUrl, "");
            }
            set
            {
                _preferences?.Set(PreferencesFields.BaseUrl, value);
            }
        }
    }
}
