﻿using System;

namespace SwedbankPay.Sdk.PaymentInstruments.MobilePay
{
    public class MobilePayPaymentAuthorizationsResponse
    {
        public MobilePayPaymentAuthorizationsResponse(Uri payment, MobilePayPaymentAuthorizationListResponse authorizationList)
        {
            Payment = payment;
            AuthorizationList = authorizationList;
        }

        /// <summary>
        /// A <seealso cref="Uri"/> point to the current payment.
        /// </summary>
        public Uri Payment { get; }

        /// <summary>
        /// A list of currently available authorizations on this payment.
        /// </summary>
        public MobilePayPaymentAuthorizationListResponse AuthorizationList { get; }
    }
}