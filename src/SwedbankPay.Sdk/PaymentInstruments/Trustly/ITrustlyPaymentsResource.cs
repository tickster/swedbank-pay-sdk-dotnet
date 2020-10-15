﻿using SwedbankPay.Sdk.PaymentInstruments.Trustly;
using System;
using System.Threading.Tasks;

namespace SwedbankPay.Sdk.Payments.TrustlyPayments
{
    public interface ITrustlyResource
    {
        /// <summary>
        ///     Creates a new Trustly payment
        /// </summary>
        /// <param name="paymentRequest"></param>
        /// <param name="paymentExpand"></param>
        /// <returns></returns>
        Task<ITrustlyPaymentResponse> Create(TrustlyPaymentRequest paymentRequest, PaymentExpand paymentExpand);

        ///// <summary>
        /////     Gets an existing swish payment.
        ///// </summary>
        ///// <param name="id"></param>
        ///// <param name="paymentExpand"></param>
        ///// <returns></returns>
        Task<ITrustlyPaymentResponse> Get(Uri id, PaymentExpand paymentExpand);
    }
}
