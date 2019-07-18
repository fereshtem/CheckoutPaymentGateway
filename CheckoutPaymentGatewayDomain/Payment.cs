using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutPaymentGatewayDomain
{
    public class Payment
    {
        public Payment(Guid identifier, Card card, decimal amount)
        {
            Identifier = identifier;
            Card = card;
            Amount = amount;
        }
        public Guid Identifier { get; set; }
        public Card Card { get; set; }
        public decimal Amount { get; set; }
        public int Status { get; set; }
    }
}
