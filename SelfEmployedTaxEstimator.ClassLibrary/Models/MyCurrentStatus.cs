using SelfEmployedTaxEstimator.ClassLibrary.Models.TaxRateSchedule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfEmployedTaxEstimator.ClassLibrary.Models
{
    public class MyCurrentStatus
    {
        public int Id { get; set; }
        public FilingStatus MyFilingStatus { get; set; }
    }
}
