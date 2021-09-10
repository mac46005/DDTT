using SelfEmployedTaxEstimator.ClassLibrary.DataAccessModels;
using SelfEmployedTaxEstimator.ClassLibrary.DataAccessModels.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfEmployedTaxEstimator.ClassLibrary.Models.SelfEmploymentTaxAndDeductions
{
    class SelfEmploymentTaxAndDeductionWK_Populator
    {
        private SelfEmploymentTaxAndDeductionWK MyWorkSheet { get; set; } = new SelfEmploymentTaxAndDeductionWK();
        private IGetById<SelfEmploymentTaxAndDeductionWK_Config> _1040Config = new SelfEmploymentTaxAndDeductionsWK_ConfigDataAccess();
        public SelfEmploymentTaxAndDeductionWK_Populator()
        {
            using (IGetById<SelfEmploymentTaxAndDeductionWK_Config> getById = new SelfEmploymentTaxAndDeductionsWK_ConfigDataAccess())
            {
                _1040Config = getById;
            }
        }
        private void SubtractL1bFromLa()
        {

        }
        private void MultiplyL2ByL2YearRate()
        {

        }
        private void MultiplyL3ByL3YearRate()
        {

        }
        private void SubtractL6FromL5()
        {

        }
        private void SmallerOfL3OrL7()
        {

        }
        private void MultiplyL8ByYearRate()
        {

        }
        private void AddL4AndL9()
        {

        }
        private void MultiplyL10ByYearRate()
        {

        }
        public SelfEmploymentTaxAndDeductionWK Populate()
        {
            return MyWorkSheet;
        }
    }
}
