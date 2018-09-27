using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutManager.DataAccess
{
    public class HttpClientService : HttpClient
    {
        private static readonly HttpClientService instance = new HttpClientService();

        private static string baseUrl = ConfigurationManager.AppSettings["resource_server"];
        static HttpClientService() { }

        private HttpClientService() : base() 
    {
            Timeout = TimeSpan.FromMilliseconds(15000);
            MaxResponseContentBufferSize = 256000;
        }

        public static HttpClientService Instance
        {
            get
            {
                return instance;
            }
        }

        public async Task<List<T>> GetListItems<T>(string url)
        {
            var uri = new Uri(string.Format(baseUrl, url));
            var response = await GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var myObject = JsonConvert.DeserializeObject<List<T>>(content);
                return myObject;
            }
            throw new Exception(response.ReasonPhrase);
        }

        public async Task<T> GetItem<T>(string url)
        {
            var uri = new Uri(string.Format(baseUrl, url));
            var response = await GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var myObject = JsonConvert.DeserializeObject<T>(content);
                return myObject;
            }
            throw new Exception(response.ReasonPhrase);
        }

        public async Task PostItem<T>(T item, string url)
        {
            var uri = new Uri(string.Format(baseUrl, url));
            var json = JsonConvert.SerializeObject(item);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = null;
            response = await PostAsync(uri, content);
            if (response.IsSuccessStatusCode)
            {
                return;
            }
            throw new Exception(response.ReasonPhrase);
        }

    }
}
