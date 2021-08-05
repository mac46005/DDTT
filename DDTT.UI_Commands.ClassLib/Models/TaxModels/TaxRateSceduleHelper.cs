using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDTT.UI_Commands.ClassLib.Models.TaxModels
{
    internal class TaxRateSceduleHelper
    {
        internal static decimal CalculateTaxAmount(decimal amount,decimal percent)
        {
            return amount* percent;
        }
    }
}
