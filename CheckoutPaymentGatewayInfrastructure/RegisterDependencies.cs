using CheckoutPaymentGatewayDomain;
using SimpleInjector;
using SimpleInjector.Lifestyles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutPaymentGatewayInfrastructure
{
    public class RegisterDependencies
    {
        public static Container Initialize()
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();

            container.Register<IPaymentService, PaymentService>(Lifestyle.Singleton);

            //if(Environment.GetEnvironmentVariable("ProgramEnvironment") == ProgramEnvironment.Development.ToString())
                container.Register<IBankService, BankService>(Lifestyle.Singleton);
            //else
            //    container.Register<IAquiringBankService, AquiringBankService>(Lifestyle.Singleton);

            return container;
        }
    }
}
