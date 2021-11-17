using IAmAnInfluencer.Core.Data;
using IAmAnInfluencer.Core.Repository;
using IAmAnInfluencer.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace IAmAnInfluencer.Infra.Service
{
    public class DeductionService: IDeductionService
    {
        private readonly IDeductionRepository deductionRepository;

        public DeductionService(IDeductionRepository _deductionRepository)
        {
            deductionRepository = _deductionRepository;
        }

        public bool addDeduction(Deduction deduction)
        {
            return deductionRepository.addDeduction(deduction);
        }

        public bool deleteDeduction(int ID)
        {
            return deductionRepository.deleteDeduction(ID);
        }

        public List<Deduction> getAllDeduction()
        {
            return deductionRepository.getAllDeduction();
        }

        public bool updateDeduction(Deduction deduction)
        {
            return deductionRepository.updateDeduction(deduction);
        }
    }
}
