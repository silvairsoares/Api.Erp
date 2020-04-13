using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Api.Erp.Shared.Http
{
    public static class RequestHttp
    {
        public static async Task<string> Request(string url)
        {
            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri(url);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var response = await client.GetStringAsync(url);
            return response;
        }
    }
}