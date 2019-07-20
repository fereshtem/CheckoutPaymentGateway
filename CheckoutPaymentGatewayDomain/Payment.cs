using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CheckoutPaymentGatewayDomain.Extensions;

namespace CheckoutPaymentGatewayDomain
{
    public class Payment
    {
        public Payment(Card card, decimal amount)
        {
            Card = card.IfNotNull();
            Amount = amount.IfPositiveNumber();
        }
        public Card Card { get; set; }
        public decimal Amount { get; set; }
    }
}
