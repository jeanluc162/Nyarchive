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

        [ActivatorUtilitiesConstructor]
        public NyarchiveClient(System.Net.Http.HttpClient httpClient, ILogger<NyarchiveClient> logger) : this(httpClient)
        {
            _logger = logger;
        }
    }
}
