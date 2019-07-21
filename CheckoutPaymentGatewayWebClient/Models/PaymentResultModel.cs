using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutPaymentGatewayWebClient.Models
{
    public enum PaymentStatus
    {
        Sucsucceed,
        Failed,
    }
    [DataContract(Name = "PaymentResult")]
    public class PaymentResultModel
    {
        [DataMember]
        public Guid Identifier { get; set; }

        [DataMember]
        public PaymentStatus Status { get; set; }
    }
}
