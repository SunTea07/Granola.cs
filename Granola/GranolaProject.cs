using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Granola
{
    class GranolaProject
    {

        class GranolaBars
        {
            static void Main(string[] args)
            {

                // Declare the variables needed
                
                int barsPerCase = 100;
                double pricePerBar = 1.50;
                double priceOfCase = 100.00;
                double studGovFee = .10;
                double profit;
                double proceeds;
                double finalOutcome;

                profit = GetProfit(pricePerBar, priceOfCase, barsPerCase);
                proceeds = GetProceeds(profit, studGovFee);
                finalOutcome = FinalOutcome(proceeds, profit);

                // Output
                Console.WriteLine("Enter the amount of cases sold:");
                double casesSold = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("The price per bar was: {0:C}", pricePerBar);
                Console.WriteLine("The cost of each case was: {0:C}", priceOfCase);
                Console.WriteLine("The percentage of student government association was: " + studGovFee + "0 / 10%");
                Console.WriteLine();
                Console.WriteLine("The gross income was: {0:C}", profit);
                Console.WriteLine("The student government fees were: {0:C}", proceeds);
                Console.WriteLine("The proceedes given to the government found is: {0:C}", finalOutcome);
                Console.ReadLine();
            }

            private static double GetPricePerBar()
            {
                throw new NotImplementedException();
            }

            // Method that gets the profit
            public static double GetProfit(double pricePerBar, double priceOfCase, int barsPerCase)
            {

                double profit;
                profit = ((pricePerBar * barsPerCase) - priceOfCase) * casesSold;
                // (($1.50 * 100)-$100.00)*29
                return profit;
            }


            // Method that gets the proceedes
            public static double GetProceeds(double profit, double studGovFee)
            {
                return (profit * studGovFee);
            }


            public static double FinalOutcome(double proceeds, double profit)
            {
                return (profit - proceeds);
            }



            public static double casesSold { get; set; }
        }
    }
}
