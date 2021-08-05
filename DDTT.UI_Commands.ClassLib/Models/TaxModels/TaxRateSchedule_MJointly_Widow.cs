using DDTT.UI_Commands.ClassLib.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            throw new NotImplementedException();
        }
    }
}
