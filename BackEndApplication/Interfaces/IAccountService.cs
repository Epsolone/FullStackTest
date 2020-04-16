using System;
using System.Collections.Generic;
using BackEndApplication.Models;

namespace BackEndApplication.Interfaces
{
    public interface IAccountService
    {
        List<Transaction> GetAccountTransactions(Guid? accountId = null);

        void CreateTransaction(TransactionType type, decimal amount, Guid? accountId = null);
    }
}
