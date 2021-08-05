using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DDTT.UI_Commands.ClassLib.Models.TaxModels.TaxRateScheduleHelper;

namespace DDTT.UI_Commands.ClassLib.Models.TaxModels
{
    internal class TaxRateSchedule_HofH
    {
        private decimal[] compareToLine3 =
        {
            0,14200,54200,86350,164900,209400,523600
        };
        public decimal TaxAmount(decimal line3)
        {
            decimal amount = 0;
            if(line3 >= compareToLine3[0] || line3 <= compareToLine3[1])
            {

            }else if(line3 >= compareToLine3[1] || line3 <= compareToLine3[2])
            {

            }else if(line3 >= compareToLine3[2] || line3 <= compareToLine3[3])
            {

            }else if(line3 >= compareToLine3[3] || line3 <= compareToLine3[4])
            {

            }else if(line3 >= compareToLine3[4] || line3 <= compareToLine3[5])
            {

            }else if(line3 >= compareToLine3[5] || line3 <= compareToLine3[6])
            {

            }else if(line3 >= compareToLine3[6])
            {

            }
            return amount;
        }
    }
}
