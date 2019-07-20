using Newtonsoft.Json;
using System.Threading.Tasks;


namespace CheckoutPaymentGatewayWebClient.Clients
{
    public class BaseClient
    {
        public async Task<T> Execute<T>(HttpClientBuilder builder)
        {
            var result = await builder.Build().SendAsync(builder.HttpRequest);
            var v = await result.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(v);
        }

        public async Task Execute(HttpClientBuilder builder)
        {
            await builder.Build().SendAsync(builder.HttpRequest);
        }
    }
}
