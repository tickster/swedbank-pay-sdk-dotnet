﻿using System;

namespace SwedbankPay.Sdk.PaymentInstruments.Invoice
{
    public class InvoicePaymentAuthorization : IdLink, IInvoicePaymentAuthorization
    {
        public InvoicePaymentAuthorization(Uri id, InvoicePaymentAuthorizationDto item)
        {
            Id = id;
            Transaction = item.Map();
        }

        public IAuthorizationTransaction Transaction { get; }
    }
}