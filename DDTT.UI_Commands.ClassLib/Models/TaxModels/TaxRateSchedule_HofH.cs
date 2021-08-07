using DDTT.ClassLib.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DDTT.ClassLib.Models.TaxModels.TaxRateScheduleHelper;

namespace DDTT.ClassLib.Models.TaxModels
{
    /// <summary>
    /// 2021 Tax Rate Scedule 
    /// Filling Status: HEAD of HOUSEHOLD
    /// </summary>
    internal class TaxRateSchedule_HofH : ICalculateTaxRate
    {
        private decimal[] compareToLine3 =
        {
            0,14200,54200,86350,164900,209400,523600
        };
        /// <summary>
        /// Takes in line 3 from form 1040 es and calculates the amount of tax to pay depending on filing status
        /// </summary>
        /// <param name="line3"></param>
        /// <returns></returns>
        public decimal TaxAmount(decimal line3)
        {
            decimal amount = 0;
            if(line3 >= compareToLine3[0] || line3 <= compareToLine3[1])
            {
                amount = CalculateTaxAmount(0, 0.10M);
            }else if(line3 >= compareToLine3[1] || line3 <= compareToLine3[2])
            {
                amount = CalculateTaxAmount(1420, 0.12M);
            }else if(line3 >= compareToLine3[2] || line3 <= compareToLine3[3])
            {
                amount = CalculateTaxAmount(6220, 0.22M);
            }else if(line3 >= compareToLine3[3] || line3 <= compareToLine3[4])
            {
                amount = CalculateTaxAmount(13293, 0.24M);
            }else if(line3 >= compareToLine3[4] || line3 <= compareToLine3[5])
            {
                amount = CalculateTaxAmount(32145, 0.32M);
            }else if(line3 >= compareToLine3[5] || line3 <= compareToLine3[6])
            {
                amount = CalculateTaxAmount(46385, 0.35M);
            }else if(line3 >= compareToLine3[6])
            {
                amount = CalculateTaxAmount(156355, 0.37M);
            }
            return amount;
        }
    }
}
