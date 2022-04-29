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
        private async Task PrepareRequestAsync(HttpClient client, HttpRequestMessage request, string url)
        {
            _logger?.LogTrace("{Url}:\r\n\tHeader:\r\n{Header}\r\n\tContent:\r\n{Content}", request.RequestUri.ToString(), String.Join(",\r\n", request.Headers.SelectMany(Header => Header.Value.Select(Value => String.Format("{0}={1}", Header.Key, Value)))), request.Content != null ? await request.Content.ReadAsStringAsync() : "");
        }
        private async Task PrepareRequestAsync(HttpClient client, HttpRequestMessage request, StringBuilder urlBuilder)
        {

        }
    }
}
