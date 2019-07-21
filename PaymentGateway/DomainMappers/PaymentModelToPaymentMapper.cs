using CheckoutPaymentGatewayDomain;
using CheckoutPaymentGatewayWebClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CheckoutPaymentGatewayWebService.DomainMappers
{
    public class PaymentModelToPaymentMapper
    {
        public static Payment Map(PaymentModel source)
        {
            return new Payment(new Card(source.Card.CardNumber, source.Card.Month, source.Card.Year, source.Card.CVV), source.Amount);
        }
    }
}