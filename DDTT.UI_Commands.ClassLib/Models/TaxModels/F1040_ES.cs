using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDTT.UI_Commands.ClassLib.Models.TaxModels
{
    /// <summary>
    /// 2021 Self Employment Tax and Deduction Worksheet Estimated Tax Worksheet
    /// </summary>
    public class F1040_ES
    {
        /// <summary>
        /// Line 1a
        /// </summary>
        public decimal ExpectedIncome { get; set; }
        /// <summary>
        /// Line 1b
        /// </summary>
        public decimal FarmInc_SSInc_RetirementDisabilityInc { get; set; }
        public decimal Line2 { get => FarmInc_SSInc_RetirementDisabilityInc - ExpectedIncome; }
        private decimal line3 { get => Line2 * 92.35M; }
        private decimal line4 { get => line3 * 0.029M; }
        /// <summary>
        /// Line 5
        /// </summary>
        private decimal SS_TaxMaxIncome = 142800;
        /// <summary>
        /// Line 6
        /// </summary>
        public decimal ExpectedWages { get; set; }
        private decimal line7 { get 
            {
                decimal value = ExpectedWages - SS_TaxMaxIncome;
                if( value < 0)
                {
                    return 0;
                }
                else
                {
                    return value; 
                }
            } }

        

    }
}
