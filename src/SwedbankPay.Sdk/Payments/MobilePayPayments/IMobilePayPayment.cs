﻿using SwedbankPay.Sdk.Payments.MobilePayPayments;

namespace SwedbankPay.Sdk.Payments
{
    public interface IMobilePayPayment
    {
        IMobilePayPaymentOperations Operations { get; }
        MobilePayPaymentResponseObject PaymentResponse { get; }
    }
}