﻿using SwedbankPay.Sdk.Payments;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwedbankPay.Sdk.PaymentOrders
{
    public interface IPaymentOrderOperations: IDictionary<LinkRelation, HttpOperation>
    {
        Func<Task<IPaymentOrder>> Abort { get; }
        Func<PaymentOrderCancelRequest, Task<CancellationResponse>> Cancel { get; }
        Func<PaymentOrderCaptureRequest, Task<CaptureResponse>> Capture { get; }
        Func<PaymentOrderReversalRequest, Task<ReversalResponse>> Reverse { get; }
        Func<PaymentOrderUpdateRequest, Task<IPaymentOrder>> Update { get; }
        HttpOperation View { get; }
    }
}