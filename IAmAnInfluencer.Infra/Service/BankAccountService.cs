using IAmAnInfluencer.Core.Data;
using IAmAnInfluencer.Core.DTO;
using IAmAnInfluencer.Core.Repository;
using IAmAnInfluencer.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace IAmAnInfluencer.Infra.Service
{
    public class BankAccountService : IBankAccountService
    {
        private readonly IBankAccountRepository bankAccountRepository;

        public BankAccountService(IBankAccountRepository _bankAccountRepository)
        {
            bankAccountRepository = _bankAccountRepository;
        }

        public bool addBankAccount(BankAccount bankAccount)
        {
            return bankAccountRepository.addBankAccount(bankAccount);
        }

        public bool deleteBankAccount(int ID)
        {
            return bankAccountRepository.deleteBankAccount(ID);
        }

        public List<BankAccount> getAllBankAccount()
        {
            return bankAccountRepository.getAllBankAccount();
        }

        public bool updateBankAccount(BankAccount bankAccount)
        {
            return bankAccountRepository.updateBankAccount(bankAccount);
        }

        public object pay(payDTO payDTO)
        {
            return bankAccountRepository.pay(payDTO);
        }
    }
}
