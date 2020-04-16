using System;
using System.Collections.Generic;
using BackEndApplication.Models;

namespace BackEndApplication.Interfaces
{
    public interface IAccountRepository
    {
        Account GetById(Guid? id = null);
        List<Transaction> GetTransactions(Guid accountId);
        void CreateTransaction(TransactionType type, decimal amount, Guid? accountId = null);
    }
}
