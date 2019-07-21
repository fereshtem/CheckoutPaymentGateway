using CheckoutPaymentGatewayDomain.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutPaymentGatewayDomain
{
    public enum EnumHelperPaymentStatus
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
        public PaymentResult()
        {
            Identifier = Guid.NewGuid();
            status = EnumHelper.ToDescription(EnumHelperPaymentStatus.Sucsucceed);
        }
        public Guid Identifier { get; set; }
        public string status { get; set; }
    }
}
