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
        private async Task ProcessResponseAsync(HttpClient client, HttpResponseMessage response, CancellationToken cancellationToken)
        {
            _logger?.LogTrace("{StatusCode}:\r\n\tHeader:\r\n{Header}\r\n\tContent:\r\n{Content}", response.StatusCode.ToString(), String.Join(",\r\n", response.Headers.SelectMany(Header => Header.Value.Select(Value => String.Format("{0}={1}", Header.Key, Value)))), response.Content != null ? await response.Content.ReadAsStringAsync() : "");
        }
    }
}
