﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfEmployedTaxEstimator.ClassLibrary.Models
{
    class _1040ES_WKPopulator
    {
        private _1040ES_SelfEmploymentTaxAndDeduction_WS MyWorkSheet { get; set; } = new _1040ES_SelfEmploymentTaxAndDeduction_WS();
        public _1040ES_WKPopulator()
        {

        }



        public _1040ES_SelfEmploymentTaxAndDeduction_WS Populate()
        {
            return MyWorkSheet;
        }
    }
}
