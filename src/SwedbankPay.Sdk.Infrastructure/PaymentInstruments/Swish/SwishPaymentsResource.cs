﻿using SwedbankPay.Sdk.Extensions;
using SwedbankPay.Sdk.Payments.SwishPayments;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace SwedbankPay.Sdk.Payments
{
    public class SwishPaymentsResource : ResourceBase, ISwishResource
    {
        public SwishPaymentsResource(HttpClient httpClient) : base(httpClient)
        {
        }

        public async Task<ISwishPayment> Get(Uri id, PaymentExpand paymentExpand = PaymentExpand.None)
        {
            if (id == null)
                throw new ArgumentNullException(nameof(id));

            Uri url = id.GetUrlWithQueryString(paymentExpand);

            var paymentResponse = await HttpClient.GetAsJsonAsync<SwishPaymentResponseDto>(url);
            return new SwishPayment(paymentResponse);
        }

        public async Task<ISwishPayment> Create(SwishPaymentRequest paymentRequest,
                                                            PaymentExpand paymentExpand = PaymentExpand.None)
        {
            var url = new Uri($"/psp/swish/payments{paymentExpand}", UriKind.Relative);

            var paymentResponse = await HttpClient.PostAsJsonAsync<SwishPaymentResponseDto>(url, paymentRequest);
            return new SwishPayment(paymentResponse);
        }
    }
}