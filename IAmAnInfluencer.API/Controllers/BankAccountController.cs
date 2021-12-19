using IAmAnInfluencer.Core.Data;
using IAmAnInfluencer.Core.DTO;
using IAmAnInfluencer.Core.Service;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IAmAnInfluencer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankAccountController : Controller
    {
        private readonly IBankAccountService bankAccountService;
        public BankAccountController(IBankAccountService _bankAccountService)
        {
            bankAccountService = _bankAccountService;
        }

        [HttpPost]
        [Route("Add")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool addBankAccount(BankAccount bankAccount)
        {
            return bankAccountService.addBankAccount(bankAccount);
        }

        [HttpDelete]
        [Route("Delete/{ID}")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool deleteBankAccount(int ID)
        {
            return bankAccountService.deleteBankAccount(ID);
        }

        [HttpGet]
        [Route("GetAll")]
        [ProducesResponseType(typeof(List<BankAccount>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<BankAccount> getAllBankAccount()
        {
            return bankAccountService.getAllBankAccount();
        }

        [HttpPut]
        [Route("Update")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool updateBankAccount(BankAccount bankAccount)
        {
            return bankAccountService.updateBankAccount(bankAccount);
        }

        [HttpPost]
        [Route("Pay")]
        [ProducesResponseType(typeof(object), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public object pay(payDTO payDTO)
        {
            return bankAccountService.pay(payDTO);
        }
    }
}
