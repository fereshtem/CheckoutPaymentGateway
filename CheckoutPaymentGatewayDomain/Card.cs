using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CheckoutPaymentGatewayDomain.Extensions;

namespace CheckoutPaymentGatewayDomain
{
    public class Card
    {
        public Card(string cardNumber, int month, int year, int cvv)
        {
            CardNumber = cardNumber.IfNotNullOrEmpty();
            Month = month.IfPositiveNumber();
            Year = year.IfPositiveNumber();
            CVV = cvv.IfPositiveNumber();
        }
        public string CardNumber { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public int CVV { get; set; }
    }
}
