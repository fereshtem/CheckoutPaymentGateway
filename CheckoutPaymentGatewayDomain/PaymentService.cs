using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CheckoutPaymentGatewayDomain.Exceptions;
using CheckoutPaymentGatewayDomain.Extensions;

namespace CheckoutPaymentGatewayDomain
{
    public class PaymentService : IPaymentService
    {
        #region Fields
        private readonly Dictionary<Guid, Payment> _payments;
        private readonly IBankService _bankService;
        #endregion
        public PaymentService(IBankService bankService)
        {
            _payments = new Dictionary<Guid, Payment>();
            _bankService = bankService;
        }
        public PaymentResult AddPayment(Payment payment)
        {
            payment.IfNotNull();
            var paymentResult = _bankService.ProcessPaymentRequest(payment);
            _payments.Add(paymentResult.Identifier, payment);
            return paymentResult;
        }

        public Payment GetPaymentHistory(Guid identifier)
        {
            Payment item = null;

            if (_payments.Keys.Contains(identifier))
            {
                item = _payments[identifier];
            }
            return item;
        }
    }
}
