using SelfEmployedTaxEstimator.ClassLibrary.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfEmployedTaxEstimator.ClassLibrary.Models._1040ES_Lines
{
    public class Line11 : IMultiplyByData
    {
        public int Id { get; set; }
        public decimal MultiplyBy { get; set; }
    }
}
