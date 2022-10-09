using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MortgageLoan

{
    
    
    
    public static class MortgageInsurance 
    {


        /*
        public static double PrincipalLoanAmount(double loanAmount, double interestRate, double fees, double LoanTenure)
        {

            Console.Write("\nWhat is the interest rate for the loan: "); //input from loan officer 
            int v = Convert.ToInt32(Console.ReadLine());
            double monthlyInterestRate = ((v/100) / 12);
            var apr = interestRate * LoanTenure; //apr over the loan life
            double Principal = loanAmount + apr * loanAmount;

            Console.WriteLine($"\nThe total repayment loan balance will be {Principal}");
            return Principal;

            Console.WriteLine($"\nThe total repayment loan balance will be {Principal}");

            var GetMonthlyPayment = Principal * (monthlyInterestRate / 12) * (Math.Pow(1 + monthlyInterestRate, 12)) * LoanTenure / (Math.Pow(1 + monthlyInterestRate, 12) * LoanTenure - 1); //get the monthly payment
            Console.WriteLine($"\nThe monthly payment for the projected loan amount is {GetMonthlyPayment}");

            Console.Write("\nWhat is the calculated monthly payment? ");
            double userInput = Convert.ToDouble(Console.ReadLine());
            string message = " ";
        }
        public static double MonthlyPayment(double mortgageInsurance, double loanAmount, double interestRate, double fees, double LoanTenure)
        {

            double totalLoanValue = mortgageInsurance + (loanAmount * (interestRate / 100 + 1));
            Console.Write("\nThe estimated total value of the mortgage will be {0}", totalLoanValue / 12);
            totalLoanValue = totalLoanValue / LoanTenure;
            Console.Write(".");
            totalLoanValue = (totalLoanValue + (totalLoanValue * 0.0125) + (totalLoanValue * 0.0075));
            totalLoanValue = (totalLoanValue / 12) * fees;
            Console.Write($"\nThe monthly payment of the mortgage for the duration is {totalLoanValue:c}"); //put monthly payment after hoa + taxes
            return totalLoanValue;
        }
        */

        /*
        public static double mortgageInsurance(double homePrice, double homeValue, double loanTerm, double downPayment, double equity, double loanAmt)
        {
            double privateMortgageInsurance = 0;
            double additionalInsurance = (homePrice * (1 + 0.01)) / (loanTerm * 12); //The calculation for loan insurance is 1 percent of the initial loan value per year, split into equal payments per year. evaluated at 10% + deficit in home value vs. loan value 

            if (equity >= 10)
                Console.Write("PMI not required!");
            else
            {
                additionalInsurance = 10 - equity;
                Console.Write("");
                Console.Write($"total monthly mortgage insurance will be {additionalInsurance:c} ({additionalInsurance:c}");
                privateMortgageInsurance = (loanAmt / 100);
            }
            Console.WriteLine();
            return privateMortgageInsurance;
        }
        */
    }
  
}


