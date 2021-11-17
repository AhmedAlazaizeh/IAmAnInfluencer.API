using IAmAnInfluencer.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace IAmAnInfluencer.Core.Repository
{
    public interface IDeductionRepository
    {
        public bool addDeduction(Deduction deduction);
        public List<Deduction> getAllDeduction();
        public bool deleteDeduction(int ID);
        public bool updateDeduction(Deduction deduction);
    }
}
