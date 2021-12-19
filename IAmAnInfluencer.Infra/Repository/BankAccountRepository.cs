using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using IAmAnInfluencer.Core.Common;
using IAmAnInfluencer.Core.Data;
using IAmAnInfluencer.Core.Repository;
using IAmAnInfluencer.Core.DTO;

namespace IAmAnInfluencer.Infra.Repository
{
    public class BankAccountRepository: IBankAccountRepository
    {
        private readonly IDbContext _dbContext;

        public BankAccountRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool addBankAccount(BankAccount bankAccount)
        {
            var p = new DynamicParameters();
            p.Add("@cardNumber", bankAccount.cardNumber, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@CVV", bankAccount.CVV, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@expDate", bankAccount.expDate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("@balance", bankAccount.balance, dbType: DbType.Double, direction: ParameterDirection.Input);
            p.Add("@userID", bankAccount.userID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dbContext.Connection.ExecuteAsync("addBankAccount", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public List<BankAccount> getAllBankAccount()
        {
            var p = new DynamicParameters();
            IEnumerable<BankAccount> result = _dbContext.Connection.Query<BankAccount>("getAllBankAccount", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
        public bool deleteBankAccount(int ID)
        {
            var p = new DynamicParameters();
            p.Add("@AccountID", ID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dbContext.Connection.ExecuteAsync("deleteBankAccount", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public bool updateBankAccount(BankAccount bankAccount)
        {
            var p = new DynamicParameters();
            p.Add("@AccountID", bankAccount.accountID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@cardNumber", bankAccount.cardNumber, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@CVV", bankAccount.CVV, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@expDate", bankAccount.expDate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("@balance", bankAccount.balance, dbType: DbType.Double, direction: ParameterDirection.Input);
            p.Add("@userID", bankAccount.userID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dbContext.Connection.ExecuteAsync("updateBankAccount", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public object pay(payDTO payDTO)
        {
            var p = new DynamicParameters();

            p.Add("@cardNumber", payDTO.cardNumber, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@CVV", payDTO.CVV, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@expDate", payDTO.expDate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("@cartSum", payDTO.cartSum, dbType: DbType.Double, direction: ParameterDirection.Input);
            object result = _dbContext.Connection.QueryFirstOrDefault("pay", p, commandType: CommandType.StoredProcedure);
            return result;
        }
    }
}
