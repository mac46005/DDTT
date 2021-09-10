using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfEmployedTaxEstimator.ClassLibrary.Models.SelfEmploymentTaxAndDeductions
{
    public class SelfEmploymentTaxAndDeductionWK
    {
        public int Id { get; set; }

        public DateTime Year { get; set; }
        /// <summary>
        /// Enter your expeced income 
        /// and profits subject to self-employment tax
        /// </summary>
        public decimal Line1a { get; set; }

        /// <summary>
        /// If you will have farm income and also recieve
        /// social security retirement or disability benefits
        /// enter your expected Conservation Reserve Program
        /// payments that will be included on scehdule F
        /// (Form 1040) or listed on Schedule K-1 (From 1065)
        /// </summary>
        public decimal Line1b { get; set; }

        /// <summary>
        /// Subtract line 1b from line 1a
        /// </summary>
        public decimal Line2 { get; set; }

        /// <summary>
        /// Multiply line 2 by percent rate for the year
        /// </summary>
        public decimal Line3 { get; set; }

        /// <summary>
        /// Multiply line 3 by percent rate for the year
        /// </summary>
        public decimal Line4 { get; set; }

        /// <summary>
        /// Social Security tax maximum income
        /// </summary>
        public decimal Line5 { get; set; }

        /// <summary>
        /// Enter your expected wages (If subject to social
        /// security tax or the 6.2% protion of tier 1 retirement tax)
        /// </summary>
        public decimal Line6 { get; set; }

        /// <summary>
        /// Subtract line 6 from line 5
        /// </summary>
        public decimal Line7 { get; set; }

        /// <summary>
        /// Enter if the smaller of line 3 or line 7
        /// NOTE if line 7 is zero or less, enter 0 on line 9 
        /// skip to line 10
        /// </summary>
        public decimal Line8 { get; set; }

        /// <summary>
        /// Multiply line 8 by percent for rate for year
        /// </summary>
        public decimal Line9 { get; set; }

        /// <summary>
        /// Add lines 4 and 9. Enter the result here and 
        /// on line 9 of your current year estimated tax worksheet
        /// 
        /// </summary>
        public decimal Line10 { get; set; }

        /// <summary>
        /// Multiply line 10 by 50 percent. This is your expected
        /// deduction for self employment tax on Schedule 1 (Form 1040)
        /// , line 14. Subtract this amount when figuring your expected
        /// AGI on line 1 of your current year Estimated Tax Worksheet
        /// </summary>
        public decimal Line11 { get; set; }


    }
}
