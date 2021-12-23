using IAmAnInfluencer.Core.Data;
using IAmAnInfluencer.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace IAmAnInfluencer.Core.Service
{
    public interface IBankAccountService
    {
        public bool addBankAccount(BankAccount bankAccount);
        public List<BankAccount> getAllBankAccount();
        public bool deleteBankAccount(int ID);
        public bool updateBankAccount(BankAccount bankAccount);
        public object pay(payDTO payDTO);
        public bool updateBalance(updateBalanceDTO updateBalanceDTO);
    }
}
