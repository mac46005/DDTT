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
        private SelfEmploymentTaxAndDeductionWK_Config _setd_Config;
        public SelfEmploymentTaxAndDeductionWK_Populator(decimal line1a,decimal line1b)
        {
            using (IGetByDate<SelfEmploymentTaxAndDeductionWK_Config> setd_ConfigDataAccess = new SelfEmploymentTaxAndDeductionsWK_ConfigDataAccess())
            {
                _setd.Line1a = line1a;
                _setd.Line1b = line1b;
                _setd_Config = setd_ConfigDataAccess.GetByDate(DateTime.Now);
            }
        }

        private void SubtractLine1b_Line1a() 
            => _setd.Line3 = _setd.Line1b - _setd.Line1a;

        private void 


    }
}
