using DDTT.ClassLib.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDTT.ClassLib.Models.BusinessModels
{
    public class DD_Pay : IDD_DataModel
    {
        public int Id { get; set; }
        /// <summary>
        /// Get and set the base pay of DD
        /// </summary>
        public decimal Amount { get; set; }
        public DateTime TimeStamp { get; set; } = DateTime.Now;
    }
}
