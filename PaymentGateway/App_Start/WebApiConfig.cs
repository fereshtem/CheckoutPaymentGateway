using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using Microsoft.Owin.Security.OAuth;
using Newtonsoft.Json.Serialization;
using CheckoutPaymentGatewayWebService.Security;
using CheckoutPaymentGatewayDomain;

namespace PaymentGateway
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            Environment.SetEnvironmentVariable("ProgramEnvironment", ProgramEnvironment.Development.ToString());

            config.MapHttpAttributeRoutes();
            
            RegisterHandlers(config);
        }

        private static void RegisterHandlers(HttpConfiguration config)
        {
            config.MessageHandlers.Add(new CorrelationIdHandler());
        }
    }
}
