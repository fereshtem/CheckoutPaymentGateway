using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutPaymentGatewayWebClient.Models
{
    [DataContract(Name = "PaymentResult")]
    public class PaymentResultModel
    {
        [DataMember]
        public Guid Identifier { get; set; }

        [DataMember]
        public int Status { get; set; }
    }
}
