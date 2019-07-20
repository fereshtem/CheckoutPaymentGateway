﻿using System;
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
        public CardModel Card { get; set; }
        public decimal Amount { get; set; }
    }
}
