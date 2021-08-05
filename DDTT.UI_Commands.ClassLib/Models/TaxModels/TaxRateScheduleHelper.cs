using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDTT.UI_Commands.ClassLib.Models.TaxModels
{
    internal class TaxRateScheduleHelper
    {
        /// <summary>
        /// The amount of tax payment times the percent of the range
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="percent"></param>
        /// <returns></returns>
        internal static decimal CalculateTaxAmount(decimal amount,decimal percent)
        {
            return amount* percent;
        }
    }
}
