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
        //Your net profit from self employment is found on schedule C (Form 1040), line 31;
        //Schedule F (Form 1040), line 34;
        //and Schedule K 1 (Form 1065), box 14, Code A.


        public FilingStatuses MyFilingStatus { get; set; }

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
        private decimal line8 { get => (line3 > line7) ? line7 : line3; }
        private decimal line9 { get => line8 * 0.124M; }
        private decimal line10 { get => line4 + line9; }

        

    }
}
