using IAmAnInfluencer.Core.Data;
using IAmAnInfluencer.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace IAmAnInfluencer.Core.Repository
{
    public interface IBankAccountRepository
    {
        public bool addBankAccount(BankAccount bankAccount);
        public List<BankAccount> getAllBankAccount();
        public bool deleteBankAccount(int ID);
        public bool updateBankAccount(BankAccount bankAccount);
        public object pay(payDTO payDTO);
        public bool updateBalance(updateBalanceDTO updateBalanceDTO);
    }
}
