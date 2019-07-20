using CheckoutPaymentGatewayWebClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutPaymentGatewayWebClient.Clients
{
    public interface IPaymentClient
    {
        string BaseRoute { get; set; }
 
        Task AddPayment(PaymentModel paymentModel);        
        Task<PaymentModel> GetOrderItem(Guid id);
    }
}
