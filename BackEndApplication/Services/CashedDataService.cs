using System;
using System.Collections.Generic;
using BackEndApplication.Interfaces;
using BackEndApplication.Models;

namespace BackEndApplication.Services
{
    public class CashedDataService : ICashedDataService
    {
        private static List<Account> _accounts;
        private static List<Transaction> _transactions;

        static CashedDataService()
        {
            _accounts = new List<Account>()
            {
                new Account()
                {
                    Id = Guid.NewGuid(),
                    Balance = 0
                }
            };

            _transactions = new List<Transaction>();
        }

        public List<Account> Accounts { get { return _accounts; } set { _accounts = value; } }
        public List<Transaction> Transactions { get { return _transactions; } set { _transactions = value; } }
    }
}
