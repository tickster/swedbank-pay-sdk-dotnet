﻿using SwedbankPay.Sdk.Common;
using System.Collections.Generic;
using System.Globalization;

namespace SwedbankPay.Sdk.PaymentInstruments.Trustly
{
    public class TrustlyPaymentRequestObject
    {
        public TrustlyPaymentRequestObject(CurrencyCode currency,
                                                List<IPrice> prices,
                                                string description,
                                                string payerReference,
                                                string userAgent,
                                                CultureInfo language,
                                                IUrls urls,
                                                PayeeInfo payeeInfo,
                                                TrustlyPrefillInfo prefillInfo)
        {
            Operation = Operation.Purchase;
            Intent = PaymentIntent.Sale;
            Currency = currency;
            Prices = prices;
            Description = description;
            PayerReference = payerReference;
            UserAgent = userAgent;
            Language = language;
            Urls = urls;
            PayeeInfo = payeeInfo;
            PrefillInfo = prefillInfo;
        }


        public CurrencyCode Currency { get; set; }
        public string Description { get; set; }
        public PaymentIntent Intent { get; set; }
        public CultureInfo Language { get; set; }
        public Operation Operation { get; set; }
        public PayeeInfo PayeeInfo { get; internal set; }
        public string PayerReference { get; set; }
        public List<IPrice> Prices { get; set; }
        public IUrls Urls { get; }
        public string UserAgent { get; set; }
        public TrustlyPrefillInfo PrefillInfo { get; set; }
    }
}