using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDTT.UI_Commands.ClassLib.Models.Interfaces
{
    internal interface ICalculateTaxRate
    {
        decimal TaxAmount(decimal line3);
    }
}
