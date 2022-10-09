using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MortgageLoan
{

    public class LoanDetails_Inputs
    {
        public double HomePrice { get; set; } // HomeValue on the market
        public double DownPayment { get; set; } // HomePrice - DownPayment = initial Loan amount
                                                //public double LoanAmount { get; set; } //This is the principal value or loan value

        public double GetLoanAmount()
        {
            return (HomePrice - DownPayment);
        }
        public double InterestRate { get; set; } //interest rate on the initial loan. compounds during the duration of the loan term
        public double LoanTenureMonths { get; set; } //duration of loan term. 30 years vs 15 years for this challenge
        public double LoanTenure
        {
            get
            {
                return LoanTenureMonths / LoanTenure;
            }
            set
            {
                LoanTenureMonths = 12 * value;
            }
        }
        public double Escrow { get; set; } // should include property tax, homewoners insurance, and applicable pmi
        public double InitialMonthlyPayment { get; set; } 
        public double MonthlyPayment { get; set; }
    }


}

