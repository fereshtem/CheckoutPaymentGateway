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
        #endregion
        public void AddPayment(Payment payment)
        {
            payment.IfNotNull();
            if (!_payments.Keys.Contains(payment.Identifier))
            {
                _payments.Add(payment.Identifier, payment);
            }
            else
            {
                Payment existedPayment = _payments[payment.Identifier];
                if (existedPayment != null)
                {
                    throw new PaymentAlreadyExistsException();
                }
                _payments.Add(payment.Identifier, payment);
            }
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
