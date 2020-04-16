using System;
using BackEndApplication.Models;

namespace BackEndApplication.Responses
{
    public class TransactionResponse
    {
        public Guid Id { get; set; }

        public Guid AccountId { get; set; }

        public DateTime CreateDate { get; set; }

        public TransactionType Type { get; set; }

        public decimal Amount { get; set; }
    }
}
