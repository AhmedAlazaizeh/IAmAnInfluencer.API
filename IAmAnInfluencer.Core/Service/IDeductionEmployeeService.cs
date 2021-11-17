using IAmAnInfluencer.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace IAmAnInfluencer.Core.Service
{
    public interface IDeductionEmployeeService
    {
        public bool addDeductionEmployee(DeductionEmployee deductionEmployee);
        public List<DeductionEmployee> getAllDeductionEmployee();
        public bool deleteDeductionEmployee(int ID);
        public bool updateDeductionEmployee(DeductionEmployee deductionEmployee);
    }
}
