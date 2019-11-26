﻿namespace SwedbankPay.Sdk.PaymentOrders
{
    using System;
    using SwedbankPay.Sdk.Payments;
    using SwedbankPay.Sdk.Transactions;

    public class CurrentPaymentResponse : IdLink
    {
        public string Number { get; set; }

        public DateTime Created { get; set; }

        public string Instrument { get; set; }
        public string Operation { get; set; }

        public string Intent { get; set; }
        public State State { get; set; }

        public CurrencyCode Currency { get; set; }
        public long Amount { get; set; }
        public string Description { get; set; }

        public string PayerReference { get; set; }

        public string UserAgent { get; set; }

        public string Language { get; set; }
        public PricesContainer Prices { get; set; }
        public IdLink Urls { get; set; }
        public PayeeInfo PayeeInfo { get; set; }

        public TransactionListContainer Transactions { get; set; }

        public AuthorizationListContainer Authorizations { get; set; }

        public CapturesListContainer Captures { get; set; }

        public ReversalsListContainer Reversals { get; set; }

        public CancellationsListContainer Cancellations { get; set; }

        public string PaymentToken { get; set; }
    }
}