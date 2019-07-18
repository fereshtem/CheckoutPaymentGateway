using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutPaymentGatewayDomain
{
    public class PaymentService : IPaymentService
    {
        #region Fields
        private readonly Dictionary<Guid, Payment> _payments;
        #endregion
        public void AddPayment(Payment payment)
        {
            if (!_payments.Keys.Contains(payment.Identifier))
            {
                _payments.Add(payment.Identifier, payment);
            }
            else
            {
                Payment existedPayment = _payments[payment.Identifier];
                if (existedPayment != null)
                {

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
