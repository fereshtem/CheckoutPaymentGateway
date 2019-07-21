using AutoMapper;
using CheckoutPaymentGatewayDomain;
using CheckoutPaymentGatewayDomain.Extensions;
using CheckoutPaymentGatewayWebClient;
using CheckoutPaymentGatewayWebClient.Models;
using CheckoutPaymentGatewayWebService.DomainMappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CheckoutPaymentGatewayWebService.Controllers.V1
{
    [RoutePrefix(ApiVersions.Version1)]
    public class PaymentController : BaseController
    {
        IPaymentService _paymentService = null;

        public PaymentController(IPaymentService paymentService)
        {
            _paymentService = paymentService.IfNotNull();
        }

        [HttpGet]
        [Route(Routes.Payment.GET_Payment, Name = Routes.RouteNames.Payment.GET_Payment)]
        public IHttpActionResult GetPayment(Guid id)
        {
            return Ok(Mapper.Map<PaymentModel>(_paymentService.GetPaymentHistory(id)));
        }

        [HttpPost]
        [Route(Routes.Payment.POST_Payment, Name = Routes.RouteNames.Payment.POST_Payment)]
        public IHttpActionResult AddPayment(PaymentModel paymentModel)
        {
            var paymentResult =_paymentService.AddPayment(PaymentModelToPaymentMapper.Map(paymentModel));
            return Json(paymentResult);
        }
    }
}
