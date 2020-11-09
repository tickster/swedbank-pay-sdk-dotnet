﻿using SwedbankPay.Sdk.PaymentInstruments;
using System;

namespace SwedbankPay.Sdk.PaymentOrders
{
    public class TransactionResponseDto
    {
        public Uri Id { get; set; }
        public TransactionDto Transaction { get; set; }

        internal ITransactionResponse Map()
        {
            return new TransactionResponse(Id.OriginalString, Transaction);
        }
    }
}