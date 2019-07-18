using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutPaymentGatewayDomain.Exceptions
{
    public class PaymentNotFoundException : DomainException
    {
        public PaymentNotFoundException() : this("Payment not found")
        {

        }
        public PaymentNotFoundException(string message) : base(message)
        {

        }
        public PaymentNotFoundException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
