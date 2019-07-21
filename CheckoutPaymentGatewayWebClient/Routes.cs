using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutPaymentGatewayWebClient
{
    public static class Routes
    {
        public static class Payment
        {
            public const string GET_Payment = "payment/{id}";
            public const string POST_Payment = "payment";
        }

        public static class RouteNames
        {
            public static class Payment
            {
                public const string GET_Payment = "payment";
                public const string POST_Payment = "PostPayment";
            }
        }
    }
}
