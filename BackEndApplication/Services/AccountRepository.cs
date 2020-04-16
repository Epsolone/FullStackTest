using System;
using System.Collections.Generic;
using System.Linq;
using BackEndApplication.Interfaces;
using BackEndApplication.Models;

namespace BackEndApplication.Services
{
    public class AccountRepository : IAccountRepository
    {
        private readonly ICashedDataService _context;

        public AccountRepository(ICashedDataService context)
        {
            _context = context;
        }

        public Account GetById(Guid? id = null)
        {
            return id != null
                ? _context.Accounts.FirstOrDefault(x => x.Id == id)
                : _context.Accounts.FirstOrDefault();
        }

        public List<Transaction> GetTransactions(Guid accountId)
        {
            return _context.Transactions
                .Where(x => x.AccountId == accountId)
                .ToList();
        }

        public void CreateTransaction(TransactionType type, decimal amount, Guid? accountId = null)
        {
            var account = GetById(accountId);

            if (type == TransactionType.Credit)
            {
                account.Balance += amount;
            }else if(type == TransactionType.Debit)
            {
                account.Balance -= amount;
            }
            else
            {
                throw new ArgumentException("Invalid Transaction type");
            }

            _context.Transactions.Add(new Transaction()
            {
                Id = Guid.NewGuid(),
                AccountId = account.Id,
                Type = type,
                Amount = amount,
                CreateDate = DateTime.UtcNow
            }); 
        }
    }
}
