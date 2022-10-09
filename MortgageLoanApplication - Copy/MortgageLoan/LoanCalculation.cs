using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MortgageLoan;

namespace MortgageLoan
{
    

    public class LoanCalculation : LoanDetails_Inputs
    {        
        public static double LoanAmount { get; private set; }
        #region //Monthly Payment Calculation
        public static double InitialMonthlyPayment(double mortgageInsurance, double loanAmount, double interestRate, double fees, double LoanTenure)
        {            

            double totalLoanValue = mortgageInsurance + (loanAmount * (interestRate / 100 + 1));
            totalLoanValue = totalLoanValue / LoanTenure;
            totalLoanValue = totalLoanValue + (loanAmount * 0.0125) + (loanAmount * 0.0075); //property tax = 1.25% or 0.0125 while homeowners insurance is 0.75% or 0.0075
            Console.Write(totalLoanValue);
            return totalLoanValue;
            //if void is changed then function must have a return value; example return totalLoanValue
        }
        public static double MonthlyPayment(double mortgageInsurance, double loanAmount, double interestRate, double fees, double LoanTenure)
        {
            
            double totalLoanValue = mortgageInsurance + (loanAmount * (interestRate / 100 + 1));
            Console.Write("\nThe estimated total value of the mortgage will be {0}", totalLoanValue /12);
            totalLoanValue = totalLoanValue / LoanTenure;
            Console.Write(".");
            totalLoanValue = (totalLoanValue + (totalLoanValue * 0.0125) + (totalLoanValue * 0.0075));
            totalLoanValue = (totalLoanValue / 12) * fees;
            Console.Write("\nThe monthly payment of the mortgage for the duration is {0}", totalLoanValue); //put monthly payment after hoa + taxes
            return totalLoanValue;
        }
        #endregion

        #region //Compute user inputs:homeValue, downpayment, etc.  
        public static double HomePuchaseDetails()
        {
            Console.Write("What is the purchase price of the Home being considered? \n");  //get price of home
            double homePrice = Convert.ToDouble(Console.ReadLine());
            return homePrice;


        }        
        public static double DownPayment()
        {
            Console.Write("What is the downPayment?\n"); //get downpayment if any
            double downPayment = Convert.ToDouble(Console.ReadLine());
            return downPayment;
        }              
        public static double GetHomePrice(double homePrice)
        {
            return homePrice;
        }
        public static double GetLoanAmount(double homePrice, double downPayment)
        {
            LoanAmount = homePrice - downPayment;
            Console.Write($"Based on the information given, the initial loan amount needed will be {LoanAmount}");
            //_ = Convert.ToDecimal(Console.ReadLine());
            //double LoanAmount = homePrice - downPayment; 
            //double loanAmount = ((homePrice - downPayment) * 0.01) + (homePrice - downPayment) + fees + InterestRate;
            //Console.Write($"The initial loan amount will be {LoanAmount} ");
            return LoanAmount;
            double loanAmount = ((homePrice - downPayment) * 0.01) + (homePrice - downPayment) +2500;
            return loanAmount;
        }
        public static double LoanTenure()
        {
            Console.Write("\nWould you like a 15 or 30 year loan term?\n");
            double loanTenure = Convert.ToDouble(Console.ReadLine()) * 12;
            Console.Write($"\nThat will be a {loanTenure} months of repayment period.");
            return loanTenure;

        }
        public static double InterestRate(double interestRate, double totalLoanValue, double loanTenure)
        {
            Console.Write("\nWhat is the interest rate for the loan?\n "); //input from loan officer 
            double InterestRate = Convert.ToDouble(Console.ReadLine()) / 100;
            double monthlyInterestRate = (InterestRate / 12);
            var apr = InterestRate * loanTenure; //apr over the loan life          

            //double principalLoan = totalLoanValue * monthlyInterestRate + totalLoanValue;
            //Console.Write($"\nThe total loan over the loan term selected will be {principalLoan}");            

            return apr;                      
        }        
        public static double Principal(double apr, double loanAmount, double monthlyInterestRate)
        {

            double principalLoan = LoanAmount * apr + LoanAmount;
            Console.Write($"\nThe total loan over the loan term selected will be {principalLoan}");
            return principalLoan;
        }        
        public static double MortgageInsurance(double homePrice, double LoanTenure, double homeEquity)
        {
            
            // double homePrice, double homeValue, double loanTenure, double downPayment, double equity, double loanAmt
            double privateMortgageInsurance = 0;
            double additionalInsurance = (homePrice * (1 + 0.01)) / (LoanTenure * 12); //The calculation for loan insurance is 1 percent of the initial loan value per year, split into equal payments per year. evaluated at 10% + deficit in home value vs. loan value 

            if (homeEquity >= 0.01 * homePrice)
                Console.Write("PMI not required!");
            else
            {
                Console.Write($"\nThere will be an additional insurance fee of {additionalInsurance:c} added to your monthly payment");
                privateMortgageInsurance = homePrice / LoanTenure *12;
            }
            Console.WriteLine();
            return privateMortgageInsurance;
        }              
    }
}
#endregion