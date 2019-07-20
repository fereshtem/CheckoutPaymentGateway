using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutPaymentGatewayDomain
{
    public interface IBankService
    {
        PaymentResult ProcessPaymentRequest(Payment payment);
    }
}
