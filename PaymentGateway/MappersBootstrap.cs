using AutoMapper;
using CheckoutPaymentGatewayDomain;
using CheckoutPaymentGatewayWebClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CheckoutPaymentGatewayWebService
{
    public class MappersBootstrap
    {
        public static void Initialize()
        {
            Mapper.Initialize(cfg => {
                cfg.CreateMap<Payment, PaymentModel>().ReverseMap();
                cfg.CreateMap<Card, CardModel>().ReverseMap();
                cfg.CreateMap<PaymentResult, PaymentResultModel>().ReverseMap();
            });
        }
    }
}