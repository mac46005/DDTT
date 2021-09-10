using SelfEmployedTaxEstimator.ClassLibrary.DataAccessModels;
using SelfEmployedTaxEstimator.ClassLibrary.DataAccessModels.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfEmployedTaxEstimator.ClassLibrary.Models.SelfEmploymentTaxAndDeductions
{
    public class SelfEmploymentTaxAndDeductionWK_Populator
    {
        private SelfEmploymentTaxAndDeductionWK _setd = new SelfEmploymentTaxAndDeductionWK();
        public decimal EstimatedIncome { get; set; }
        
    }
}
