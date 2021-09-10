using SelfEmployedTaxEstimator.ClassLibrary.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfEmployedTaxEstimator.ClassLibrary.Models.TaxRateSchedule
{
    public class TRateSingle : ITaxRateSchedule
    {
        public const FilingStatus TRS_FilingStatus = FilingStatus.Single;
        public int Id { get; set; }
        public DateTime Year { get; set; }
        public List<decimal> Line3Amounts { get; set; }
        public List<decimal> TaxDollarAmounts { get; set; }
        public List<decimal> PercentageAmounts { get; set; }

    }
}
