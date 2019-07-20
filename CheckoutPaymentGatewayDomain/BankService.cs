using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutPaymentGatewayDomain
{
    public class BankService : IBankService
    {
        public PaymentResult ProcessPaymentRequest(Payment payment)
        {
            return new PaymentResult() { Identifier = new Guid(), status = PaymentStatus.Sucsucceed };
        }
    }
}
