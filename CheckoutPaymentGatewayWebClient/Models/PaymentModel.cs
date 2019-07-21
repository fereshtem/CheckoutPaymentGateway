using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutPaymentGatewayWebClient.Models
{
    [DataContract(Name = "Payment")]
    public class PaymentModel
    {
        [DataMember]
        public CardModel Card { get; set; }
        [DataMember]
        public decimal Amount { get; set; }
    }
}
