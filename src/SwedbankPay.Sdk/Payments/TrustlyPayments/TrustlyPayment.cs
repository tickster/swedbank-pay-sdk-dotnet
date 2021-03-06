﻿using SwedbankPay.Sdk.Extensions;

using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace SwedbankPay.Sdk.Payments.TrustlyPayments
{
    public class TrustlyPayment
    {
        private TrustlyPayment(TrustlyPaymentResponse paymentResponse, HttpClient client)
        {
            PaymentResponse = paymentResponse.Payment;
            var operations = new TrustlyPaymentOperations(paymentResponse.Operations, client);
            Operations = operations;
        }


        public TrustlyPaymentOperations Operations { get; }

        public PaymentResponseObject PaymentResponse { get; }


        internal static async Task<TrustlyPayment> Create(TrustlyPaymentRequest paymentRequest,
                                                          HttpClient client,
                                                          string paymentExpand)
        {
            var url = new Uri($"/psp/trustly/payments{paymentExpand}", UriKind.Relative);

            var paymentResponse = await client.PostAsJsonAsync<TrustlyPaymentResponse>(url, paymentRequest);
            return new TrustlyPayment(paymentResponse, client);
        }


        internal static async Task<TrustlyPayment> Get(Uri id, HttpClient client, string paymentExpand)
        {
            var url = !string.IsNullOrWhiteSpace(paymentExpand)
                ? new Uri(id.OriginalString + paymentExpand, UriKind.RelativeOrAbsolute)
                : id;

            var paymentResponse = await client.GetAsJsonAsync<TrustlyPaymentResponse>(url);
            return new TrustlyPayment(paymentResponse, client);
        }
    }
}
