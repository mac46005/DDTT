using DDTT.ClassLib.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDTT.ClassLib.Models.BusinessModels
{
    public class ExpenseType : ISqlItemId
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
    }
}
