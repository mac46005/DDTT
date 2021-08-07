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
        public DD_Pay DD_Pay { get; set; }
        public Tip Tip { get; set; }
    }
}
