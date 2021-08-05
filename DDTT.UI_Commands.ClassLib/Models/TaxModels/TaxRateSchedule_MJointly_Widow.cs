using DDTT.UI_Commands.ClassLib.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DDTT.UI_Commands.ClassLib.Models.TaxModels.TaxRateScheduleHelper;

namespace DDTT.UI_Commands.ClassLib.Models.TaxModels
{
    internal class TaxRateSchedule_MJointly_Widow : ICalculateTaxRate
    {
        private decimal[] compareToLine3 =
        {
            0,19900,81050,172750,329850,418850,628300
        };

        public decimal TaxAmount(decimal line3)
        {
            decimal amount = 0;
            if (line3 >= compareToLine3[0] || line3 <= compareToLine3[1])
            {
                amount = CalculateTaxAmount(0,0.10M);
            }
            else if (line3 >= compareToLine3[1] || line3 <= compareToLine3[2])
            {
                amount = CalculateTaxAmount(1990, 0.12M);
            }
            else if (line3 >= compareToLine3[2] || line3 <= compareToLine3[3])
            {
                amount = CalculateTaxAmount(9328, 0.22M);
            }
            else if (line3 >= compareToLine3[3] || line3 <= compareToLine3[4])
            {
                amount = CalculateTaxAmount(29502, 0.24M);
            }
            else if (line3 >= compareToLine3[4] || line3 <= compareToLine3[5])
            {
                amount = CalculateTaxAmount(67206, 0.32M);
            }
            else if (line3 >= compareToLine3[5] || line3 <= compareToLine3[6])
            {
                amount = CalculateTaxAmount(95686, 0.35M);
            }
            else if (line3 >= compareToLine3[6])
            {
                amount = CalculateTaxAmount(168993, 0.37M);
            }
            return amount;
        }
    }
}
