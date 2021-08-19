using DDTT.ClassLib.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDTT.ClassLib.Models.BusinessModels
{
    public class Expenditure : ISqlItemId
    {
        public int Id { get; set; }
        public int JobTypeId { get; set; }
        public JobType JobType { get; set; }
        public decimal Amount { get; set; }
        public DateTime TimeStamp { get; set; } = DateTime.Now;
        public int ExpenseTypeId { get; set; }
        public ExpenseType ExpenseType { get; set; }
        public int Note { get; set; }
    }
}
