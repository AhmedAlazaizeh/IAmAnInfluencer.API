using IAmAnInfluencer.Core.Data;
using IAmAnInfluencer.Core.Service;
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
    public class DeductionEmployeeController : ControllerBase
    {
        private readonly IDeductionEmployeeService deductionEmployeeService;
        public DeductionEmployeeController(IDeductionEmployeeService _deductionEmployeeService)
        {
            deductionEmployeeService = _deductionEmployeeService;
        }

        [HttpPost]
        [Route("Add")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool addDeductionEmployee(DeductionEmployee deductionEmployee)
        {
            return deductionEmployeeService.addDeductionEmployee(deductionEmployee);
        }

        [HttpDelete]
        [Route("Delete/{ID}")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool deleteDeductionEmployee(int ID)
        {
            return deductionEmployeeService.deleteDeductionEmployee(ID);
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<DeductionEmployee>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<DeductionEmployee> getAllDeductionEmployee()
        {
            return deductionEmployeeService.getAllDeductionEmployee();
        }

        [HttpPut]
        [Route("Update")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool updateDeductionEmployee(DeductionEmployee deductionEmployee)
        {
            return deductionEmployeeService.updateDeductionEmployee(deductionEmployee);
        }
    }
}
