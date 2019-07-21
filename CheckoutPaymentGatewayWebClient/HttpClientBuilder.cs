using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutPaymentGatewayWebClient
{
    public class HttpClientBuilder
    {
        private HttpClient _httpClient = new HttpClient();
        private Dictionary<string, Guid> _uriSegments = new Dictionary<string, Guid>();

        public HttpRequestMessage HttpRequest { get; } = new HttpRequestMessage();
        public string BaseRoute { get; private set; }

        public HttpClientBuilder()
        {

        }

        public HttpClientBuilder WithHeader(string name, string value)
        {
            _httpClient.DefaultRequestHeaders.Add(name, value);
            return this;
        }
        public HttpClientBuilder WithBody<T>(T content)
        {
            HttpRequest.Content = new StringContent(JsonConvert.SerializeObject(content), Encoding.UTF8, "application/json");
            return this;
        }
        public HttpClientBuilder AsGET()
        {
            HttpRequest.Method = HttpMethod.Get;
            return this;
        }
        public HttpClientBuilder AsPost()
        {
            HttpRequest.Method = HttpMethod.Post;
            return this;
        }
        public HttpClientBuilder AsPut()
        {
            HttpRequest.Method = HttpMethod.Put;
            return this;
        }
        public HttpClientBuilder AsDelete()
        {
            HttpRequest.Method = HttpMethod.Delete;
            return this;
        }
        public HttpClientBuilder WithUriSehment(string name, Guid value)
        {
            _uriSegments.Add(name, value);
            return this;
        }
        public HttpClientBuilder WithRoute(string route)
        {
            var fullRoute = $"{BaseRoute}/{ApiVersions.Version1}/{route}";

            foreach (var item in _uriSegments)
            {
                fullRoute = fullRoute.Replace("{" + item.Key + "}", item.Value.ToString());
            }

            HttpRequest.RequestUri = new Uri(fullRoute);
            return this;
        }
        public HttpClientBuilder WithBaseRoute(string baseRoute)
        {
            BaseRoute = baseRoute;
            return this;
        }

        public HttpClient Build()
        {
            return _httpClient;
        }
    }
}