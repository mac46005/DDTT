using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfEmployedTaxEstimator.ClassLibrary.Models.Interfaces
{
    public interface IMultiplyByData
    {
        int Id { get; set; }
        decimal MultiplyBy { get; set; }
    }
}
