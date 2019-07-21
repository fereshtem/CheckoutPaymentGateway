using CheckoutPaymentGatewayInfrastructure;
using CheckoutPaymentGatewayWebService;
using SimpleInjector;
using SimpleInjector.Integration.WebApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace PaymentGateway
{
        public class WebApiApplication : System.Web.HttpApplication
        {
            protected void Application_Start()
            {
                GlobalConfiguration.Configure(WebApiConfig.Register);
                MappersBootstrap.Initialize();


                var container = RegisterDependencies.Initialize();
                container.RegisterWebApiControllers(GlobalConfiguration.Configuration);

                container.Verify();

                GlobalConfiguration.Configuration.DependencyResolver =
                    new SimpleInjectorWebApiDependencyResolver(container);
            }
        }
}
