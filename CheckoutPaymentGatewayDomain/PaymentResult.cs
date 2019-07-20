using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutPaymentGatewayDomain
{
    public enum PaymentStatus
    {
        Sucsucceed,
        Failed,
    }
    public enum ProgramEnvironment
    {
        Development,
        Production,
    }
    public class PaymentResult
    {
        public Guid Identifier { get; set; }
        public PaymentStatus status { get; set; }
    }
}
