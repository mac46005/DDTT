using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfEmployedTaxEstimator.ClassLibrary.Models.EstimatedTaxes
{
    public class EstimatedTaxWorkSheet
    {
        public DateTime CurrentYear { get; set; }


        /// <summary>
        /// Adjusted gross income you expent in CURRENT YEAR
        /// </summary>
        public decimal Line1 { get; set; }

        /// <summary>
        /// DEDUCTIONS
        /// 2a If you plan to itemize deductions, enter the total of your itemized deductions
        /// </summary>
        public decimal Line2a { get; set; }

        /// <summary>
        /// DEDUCTIONS
        /// 2b If you don't plan to itemize deductions, enter your standard deductions
        /// </summary>
        public decimal Line2b { get; set; }

        /// <summary>
        /// Subtract line 2c from line 1
        /// </summary>
        public decimal Line3 { get; set; }

        /// <summary>
        /// Tax. Figure your tax on the amount on line 3 by using the CURRENT YEAR Tax Rate Schedulers
        /// CAUTION: If you will have qualified dividends or a net capitol gain, or expect to exclude or
        /// deduct foreign earned income or housing. See worksheets 2-5 and 2-6 in Pub. 505 to figre tax
        /// </summary>
        public decimal Line4 { get; set; }

        /// <summary>
        /// Alternatize minimum tax form FORM 6251
        /// </summary>
        public decimal Line5 { get; set; }

        /// <summary>
        /// Add lines 4 and 5. Add to this amount any other taxes you expext to include in the total on Form 1040
        /// </summary>
        public decimal Line6 { get; set; }

        /// <summary>
        /// Credits(see instructions). DO NOT include any income tax withholding on this line
        /// </summary>
        public decimal Line7 { get; set; }

        /// <summary>
        /// Subtract line 7 from line 6
        /// </summary>
        public decimal Line8 { get; set; }

        /// <summary>
        /// Self-emloyment tax (see instructions
        /// </summary>
        public decimal Line9 { get; set; }

        /// <summary>
        /// Other taxes(see instructions)
        /// </summary>
        public decimal Line10 { get; set; }

        /// <summary>
        /// 11a Add lines 8 through 10
        /// </summary>
        public decimal Line11a { get; set; }

        /// <summary>
        /// 11b Earned income credit, additional child tax credit, fuel tax credit,
        /// net premium tax credit, refundable American opportunity credit, and refundable credit from FORM 8885
        /// </summary>
        public decimal Line11b { get; set; }

        /// <summary>
        /// Total CURRENT YEAR estimated tax. Subtract line 11b from line 11a, if zero or less, anter -0-
        /// </summary>
        public decimal Line11c { get; set; }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //LINE 12
        /// <summary>
        /// Multiply line 11c by CURRENT Year Rate (or CURRENT YEAR rate for farmers and fishermen)
        /// </summary>
        public decimal Line12a { get; set; }

        /// <summary>
        /// Required annual payment based on prior years's tax(see instructions)
        /// </summary>
        public decimal Line12b { get; set; }

        /// <summary>
        /// REQUIRED ANNUAL PAYMENT TO AVOID A PENALTY.
        /// Enter the SMALLER of line 12a or 12b
        /// CAUTION: Henerally, if you do not prepay (through income tax withholding and estimated
        /// tax payments) at least the amount on line 12c, you may owe a penalty for not paying enough estimated tax.
        /// To avoid a penalty, make sure your estimate on line 11c is as accurate as possible. Even if you pay the
        /// required annual payment, you may still owe tax when you file your return. If you prefer, you can pay
        /// the amount shown on line 11c. For details see chapter 2 of Pub. 505.
        /// </summary>
        public decimal Line12c { get; set; }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        /// <summary>
        /// Income tax withheld and estimated to be withheld during CURRENT YEAR (including income tax withholding
        /// on pensions, annuities, certain deferred income, etc...)
        /// </summary>
        public decimal Line13 { get; set; }

        /// <summary>
        /// Subtract line 13 from line 12c
        /// Is the result zero or less?
        /// Yes. Stop here. You are not required to make estimated tax payments.
        /// No. Fo to line 14b.
        /// </summary>
        public decimal Line14a { get; set; }

        /// <summary>
        /// Subtract line 13 from line 11c
        /// Is result less than 1000?
        /// Yes. Stop here. You are not required to make estimated tax payments.
        /// No. Fo to line 15 to figure your required payment.
        /// </summary>
        public decimal Line14b { get; set; }

        /// <summary>
        /// If the first payment you are required to male is due April 15, 2021, enter 1/4 of line
        /// 14a (minus any 2020 overpayment that you are applying to this installment) here, and
        /// on your estimated tax payment voucher(s) if you are paying by check or money order
        /// * if applicable...
        /// </summary>
        public decimal Line15 { get; set; }
    }
}
