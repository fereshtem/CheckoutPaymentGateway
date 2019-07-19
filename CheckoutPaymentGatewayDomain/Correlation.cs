using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CheckoutPaymentGatewayDomain.Extensions;

namespace CheckoutPaymentGatewayDomain
{
    public class Correlation
    {
        public Correlation(Guid correlationId)
        {
            CorrelationId = correlationId;
        }

        public Guid CorrelationId { get; }
    }
}
