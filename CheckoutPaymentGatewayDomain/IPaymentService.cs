using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutPaymentGatewayDomain
{
    public interface IPaymentService
    {
        Payment GetPaymentHistory(Guid identifier);
        void AddPayment(Payment payment);
    }
}
