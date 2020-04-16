using System.Collections.Generic;
using BackEndApplication.Models;

namespace BackEndApplication.Interfaces
{
    public interface ICashedDataService
    {
        public List<Account> Accounts { get; set; }
        public List<Transaction> Transactions { get; set; }
    }
}
