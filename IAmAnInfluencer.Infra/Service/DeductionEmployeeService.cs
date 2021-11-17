using IAmAnInfluencer.Core.Data;
using IAmAnInfluencer.Core.Repository;
using IAmAnInfluencer.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace IAmAnInfluencer.Infra.Service
{
    public class DeductionEmployeeService: IDeductionEmployeeService
    {
        private readonly IDeductionEmployeeRepository deductionEmployeeRepository;

        public DeductionEmployeeService(IDeductionEmployeeRepository _deductionEmployeeRepository)
        {
            deductionEmployeeRepository = _deductionEmployeeRepository;
        }

        public bool addDeductionEmployee(DeductionEmployee deductionEmployee)
        {
            return deductionEmployeeRepository.addDeductionEmployee(deductionEmployee);
        }

        public bool deleteDeductionEmployee(int ID)
        {
            return deductionEmployeeRepository.deleteDeductionEmployee(ID);
        }

        public List<DeductionEmployee> getAllDeductionEmployee()
        {
            return deductionEmployeeRepository.getAllDeductionEmployee();
        }

        public bool updateDeductionEmployee(DeductionEmployee deductionEmployee)
        {
            return deductionEmployeeRepository.updateDeductionEmployee(deductionEmployee);
        }
    }
}
