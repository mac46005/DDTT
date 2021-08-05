using DDTT.UI_Commands.ClassLib.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDTT.UI_Commands.ClassLib.Models.BusinessModels
{
    public class Expenditure : IMoneyHandler
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
