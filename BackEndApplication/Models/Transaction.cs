using System;

namespace BackEndApplication.Models
{
    public class Transaction
    {
        public Guid Id { get; set; }

        public Guid AccountId { get; set; }

        public DateTime CreateDate { get; set; }

        public TransactionType Type { get; set; }

        public decimal Amount { get; set; }
    }
}
