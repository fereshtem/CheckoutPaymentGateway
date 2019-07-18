using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutPaymentGatewayDomain.Exceptions
{
    public class PaymentAlreadyExistsException : DomainException
    {
        public PaymentAlreadyExistsException() : this("Payment exists and cannot be added again")
        {

        }
        public PaymentAlreadyExistsException(string message) : base(message)
        {

        }
        public PaymentAlreadyExistsException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
