// See https://aka.ms/new-console-template for more information
//Enhance UI
namespace MortgageLoan

{
    public class Program
    {
        #region
        //private static double LoanTenure;
        private static double homePrice;
        private static double downPayment;
        private static double interestRate;
        private static double LoanAmount;
        private static double apr;
        private static double homeEquity;
        private static double v;
        private static double InterestRate;
        private static double fees;
        private static double mortgageInsurance;
        //private static double loanTenure;
        #endregion
        static void Main(string[] args)
        {

            double homePrice = LoanCalculation.HomePuchaseDetails();
            double downPayment = LoanCalculation.DownPayment();
            double loanAmount = LoanCalculation.GetLoanAmount(homePrice, downPayment);
            double LoanTenure = LoanCalculation.LoanTenure();
            double InterestRate = LoanCalculation.InterestRate(LoanAmount, LoanTenure, interestRate);
            double Principal = LoanCalculation.Principal(LoanTenure, apr, InterestRate);
            double loanInsurance = LoanCalculation.MortgageInsurance(homePrice, LoanTenure, homeEquity);
            double InitialMonthlyPayment = LoanCalculation.InitialMonthlyPayment(mortgageInsurance, loanAmount, interestRate, fees, LoanTenure);
            double MonthlyPayment = LoanCalculation.MonthlyPayment(mortgageInsurance, loanAmount, interestRate, fees, LoanTenure);
            //double PrincipalLoanAmount = MortgageInsurance.PrincipalLoanAmount(loanAmount, interestRate, fees, LoanTenure);

        }      
    }
}

