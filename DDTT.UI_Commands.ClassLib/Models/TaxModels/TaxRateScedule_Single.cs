using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DDTT.UI_Commands.ClassLib.Models.TaxModels.TaxRateSceduleHelper;

namespace DDTT.UI_Commands.ClassLib.Models.TaxModels
{
    /// <summary>
    /// 2021 Tax Rate Scedule 
    /// Filling Status: SINGLE
    /// </summary>
    /// 
    internal class TaxRateScedule_Single
    {

        private decimal[] compareToLine3 = 
            {0,9950,40525,86375,164925,209425,523600};
        public decimal TaxAmount(decimal line3)
        {
            decimal total = 0;
            if (line3 >= compareToLine3[0] || line3 <= compareToLine3[1])
            {
                total = CalculateTaxAmount(0, 0.1M);
            } else if (line3 >= compareToLine3[1] || line3 <= compareToLine3[2])
            {
                total = CalculateTaxAmount(995, 0.12M);
            } else if (line3 >= compareToLine3[2] || line3 <= compareToLine3[3])
            {
                total = CalculateTaxAmount(4664, 0.22M);
            } else if (line3 >= compareToLine3[3] || line3 <= compareToLine3[4])
            {
                total = CalculateTaxAmount(14751, 0.24M);
            } else if (line3 >= compareToLine3[4] || line3 <= compareToLine3[5])
            {
                total = CalculateTaxAmount(33603, 0.32M);
            }else if (line3 >= compareToLine3[5] || line3 <= compareToLine3[6])
            {
                total = CalculateTaxAmount(47843, 0.35M);
            }else if (line3 >= compareToLine3[6])
            {
                total = CalculateTaxAmount(157804.25M, 0.37M);
            }
            
            return total;
        }
    }
}
