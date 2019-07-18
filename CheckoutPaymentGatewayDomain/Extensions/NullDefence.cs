using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutPaymentGatewayDomain.Extensions
{
    public static class NullDefence
    {
        public static string IfNotNullOrEmpty(this string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                throw new ArgumentException();
            }

            return str;
        }
        public static T IfNotNull<T>(this T obj) where T : class
        {
            if (obj == null)
            {
                throw new ArgumentNullException();
            }

            return obj;
        }
        public static IEnumerable<T> IfNotNullOrEmpty<T>(this IEnumerable<T> obj) where T : class
        {
            if (obj == null || !obj.Any())
            {
                throw new ArgumentException();
            }

            return obj;
        }
        public static int IfPositiveNumber(this int number)
        {
            if (number <= 0)
            {
                throw new ArgumentException();
            }

            return number;
        }
        public static decimal IfPositiveNumber(this decimal number)
        {
            if (number <= 0)
            {
                throw new ArgumentException();
            }

            return number;
        }
    }
}
