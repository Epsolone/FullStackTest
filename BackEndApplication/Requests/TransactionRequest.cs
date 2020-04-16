using BackEndApplication.Models;

namespace BackEndApplication.Requests
{
    public class TransactionRequest
    {
        public TransactionType Type { get; set; }

        public decimal Amount { get; set; }
    }
}
