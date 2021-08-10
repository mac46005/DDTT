using DDTT.ClassLib.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDTT.ClassLib.Models.BusinessModels
{
    public class Income
    {
        public int Id { get; set; }
        public int JobTypeId { get; set; }
        public int JobType { get; set; }
        public decimal BasePay { get; set; }
        public decimal Tip { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
