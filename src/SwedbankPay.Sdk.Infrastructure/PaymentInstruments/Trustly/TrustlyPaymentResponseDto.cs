﻿using System.Net.Http;

namespace SwedbankPay.Sdk.PaymentInstruments.Trustly
{
    public class TrustlyPaymentResponseDto
    {
        public TrustlyPaymentDto Payment { get; set; }
        public PaymentOperationsDto Operations { get; set; }

        public ITrustlyPaymentResponse Map(HttpClient httpClient)
        {
            return new TrustlyPaymentResponse(this, httpClient);
        }
    }
}