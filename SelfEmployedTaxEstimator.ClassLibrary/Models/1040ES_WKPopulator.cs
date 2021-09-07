using SelfEmployedTaxEstimator.ClassLibrary.DataAccessModels;
using SelfEmployedTaxEstimator.ClassLibrary.DataAccessModels.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfEmployedTaxEstimator.ClassLibrary.Models
{
    class _1040ES_WKPopulator
    {
        private _1040ES_SelfEmploymentTaxAndDeduction_WS MyWorkSheet { get; set; } = new _1040ES_SelfEmploymentTaxAndDeduction_WS();
        private IGetById<_1040ES_ConfigDataAccess> getById = (IGetById<_1040ES_ConfigDataAccess>)new _1040ES_ConfigDataAccess();
        public _1040ES_WKPopulator()
        {
            using (IGetById<_1040ES_ConfigDataAccess> cnn = new _1040ES_ConfigDataAccess())
            {

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
        public _1040ES_SelfEmploymentTaxAndDeduction_WS Populate()
        {
            return MyWorkSheet;
        }
    }
}
