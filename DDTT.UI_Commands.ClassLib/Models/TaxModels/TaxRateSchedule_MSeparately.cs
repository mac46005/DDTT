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
    /// Filling Status: Married Filing Separately
    /// </summary>
    class TaxRateSchedule_MSeparately : ICalculateTaxRate
    {
        private decimal[] compareToLine3 =
        {
            0,995,4664,14751,33603,47843,84496.75M
        };
        /// <summary>
        /// Takes in line 3 from form 1040 es and calculates the amount of tax to pay depending on filing status
        /// </summary>
        /// <param name="line3"></param>
        /// <returns></returns>
        public decimal TaxAmount(decimal line3)
        {
            decimal amount = 0;
            if (line3 >= compareToLine3[0] || line3 <= compareToLine3[1])
            {
                amount = CalculateTaxAmount(0, 0.10M);
            }
            else if (line3 >= compareToLine3[1] || line3 <= compareToLine3[2])
            {
                amount = CalculateTaxAmount(995, 0.12M);
            }
            else if (line3 >= compareToLine3[2] || line3 <= compareToLine3[3])
            {
                amount = CalculateTaxAmount(4664, 0.22M);
            }
            else if (line3 >= compareToLine3[3] || line3 <= compareToLine3[4])
            {
                amount = CalculateTaxAmount(14751, 0.24M);
            }
            else if (line3 >= compareToLine3[4] || line3 <= compareToLine3[5])
            {
                amount = CalculateTaxAmount(33603, 0.32M);
            }
            else if (line3 >= compareToLine3[5] || line3 <= compareToLine3[6])
            {
                amount = CalculateTaxAmount(47843, 0.35M);
            }
            else if (line3 >= compareToLine3[6])
            {
                amount = CalculateTaxAmount(84496.75M, 0.37M);
            }
            return amount;
        }
    }
}
