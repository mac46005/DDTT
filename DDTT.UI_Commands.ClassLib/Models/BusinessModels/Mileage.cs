using DDTT.UI_Commands.ClassLib.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDTT.UI_Commands.ClassLib.Models.BusinessModels
{
    public class Mileage : IDD_DataModel
    {
        public int Id { get; set; }
        /// <summary>
        /// Get and set the mileage done for the run
        /// </summary>
        public decimal Amount { get; set; }
        public DateTime TimeStamp { get; set; } = DateTime.Now;
    }
}
