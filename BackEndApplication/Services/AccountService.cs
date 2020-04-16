using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading;
using BackEndApplication.Interfaces;
using BackEndApplication.Models;

namespace BackEndApplication.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;
        private ReaderWriterLockSlim _locker = new ReaderWriterLockSlim();

        public AccountService(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public List<Transaction> GetAccountTransactions(Guid? accountId = null)
        {
            _locker.EnterReadLock();

            try
            {
                var account = _accountRepository.GetById(accountId);
                return _accountRepository.GetTransactions(account.Id);
            }
            finally
            {
                _locker.ExitReadLock();
            }
        }

        public void CreateTransaction(TransactionType type, decimal amount, Guid? accountId = null)
        {
            if (amount < 0)
            {
                throw new ValidationException("negative amount not allowed");
            }

            _locker.EnterWriteLock();

            try
            {
                _accountRepository.CreateTransaction(type, amount, accountId);
            }
            finally
            {
                _locker.ExitWriteLock();
            }
        }
    }
}
