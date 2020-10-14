﻿using SwedbankPay.Sdk.Payments.CardPayments;
using System;
using System.Globalization;

namespace SwedbankPay.Sdk.Payments
{
    public interface ICardPayment
    {
        Amount Amount { get; }
        Amount RemainingCaptureAmount { get; }
        Amount RemainingCancellationAmount { get; }
        Amount RemainingReversalAmount { get; }
        ICardPaymentAuthorizationListResponse Authorizations { get; }
        ICancellationsListResponse Cancellations { get; }
        ICapturesListResponse Captures { get; }
        DateTime Created { get; }
        DateTime Updated { get; }
        CurrencyCode Currency { get; }
        string Description { get; }
        Uri Id { get; }
        PaymentInstrument Instrument { get; }
        PaymentIntent Intent { get; }
        CultureInfo Language { get; }
        string Number { get; }
        Operation Operation { get; }
        PayeeInfo PayeeInfo { get; }
        string PayerReference { get; }
        string InitiatingSystemUserAgent { get; }
        IPricesListResponse Prices { get; }
        IReversalsListResponse Reversals { get; }
        State State { get; }
        ITransactionListResponse Transactions { get; }
        IUrls Urls { get; }
        string UserAgent { get; }
        MetadataResponse Metadata { get; }
    }
}