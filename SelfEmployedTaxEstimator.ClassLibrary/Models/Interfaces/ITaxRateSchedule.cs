using SelfEmployedTaxEstimator.ClassLibrary.Models.TaxRateSchedule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfEmployedTaxEstimator.ClassLibrary.Models.Interfaces
{
    public interface ITaxRateSchedule
    {
        int Id { get; set; }
        DateTime Year { get; set; }
        List<decimal> Line3Amounts { get; set; }
        List<decimal> TaxDollarAmounts { get; set; }
        List<decimal> PercentageAmounts { get; set; }

    }
}
