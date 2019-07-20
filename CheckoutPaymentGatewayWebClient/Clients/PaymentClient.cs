using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CheckoutPaymentGatewayWebClient.Models;

namespace CheckoutPaymentGatewayWebClient.Clients
{
    public class PaymentClient : BaseClient, IPaymentClient
    {
        public string BaseRoute { get; set; } = "";

        public async Task AddPayment(PaymentModel paymentModel)
        {
            var clientBuilder = new HttpClientBuilder()
                .AsPost()
                .WithBaseRoute(BaseRoute)
                .WithBody<PaymentModel>(paymentModel)
                .WithRoute(Routes.Payment.POST_Payment);

            await Execute(clientBuilder);
        }

        public async Task<PaymentModel> GetOrderItem(Guid id)
        {
            var clientBuilder = new HttpClientBuilder()
                .AsGET()
                .WithBaseRoute(BaseRoute)
                .WithUriSehment("id", id)
                .WithRoute(Routes.Payment.GET_Payment);

            return await Execute<PaymentModel>(clientBuilder);
        }
    }
}
