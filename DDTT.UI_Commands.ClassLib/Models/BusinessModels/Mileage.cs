using DDTT.ClassLib.Models.Interfaces;
using DDTT.ClassLib.Models.BusinessModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDTT.ClassLib.Models.BusinessModels
{
    public class Mileage : ISqlItemId
    {
        public int Id { get; set; }
        public int JobTypeId { get; set; }
        public JobType JobType { get; set; }
        public decimal Amount { get; set; }
        public DateTime TimeStamp { get; set; } = DateTime.Now;
    }
}