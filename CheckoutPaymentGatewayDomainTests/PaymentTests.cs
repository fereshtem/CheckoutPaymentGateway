using NUnit.Framework;
using System;
using CheckoutPaymentGatewayDomain;
using FluentAssertions;

namespace CheckoutPaymentGatewayDomainTests
{
    public class PaymentTests
    {
        [Test]
        public void Ctor_WithCardNull_ShouldThrowArgumentNullException()
        {
            Action act = () => new Payment(null, 100);
            act.ShouldThrow<ArgumentNullException>();
        }
        [TestCase("")]
        public void Ctor_WithCardNull_ShouldThrowArgumentException(string cardNo)
        {
            Action act = () => new Payment(new Card(cardNo, 1,2020, 142), 10);
            act.ShouldThrow<ArgumentException>();
        }
    }
}
