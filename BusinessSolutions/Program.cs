/*  Author: Jackson Westphall
 *  Date:   September 15th 2025
 *  Description: this is a buissness calculation practice
 */
using System;
using System.Diagnostics;
using System.Dynamic;
using System.Net.Http.Headers;

namespace BusinessSolutions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DisplayMenu();
        }
        private static void DisplayMenu()
        {
            Console.Title = "Menu";
            int menuOption; //Declare variable
            Console.WriteLine("Select Number to Order...");
            Console.WriteLine("\t1. Cost Increase");
            Console.WriteLine("\t2. Calculate Inventory");
            Console.WriteLine("\t3. Calculate Property Tax");
            Console.WriteLine("\t4. Exit");
            Console.Write($"\n{"Enter Number Object",-23}");
            menuOption = int.Parse(Console.ReadLine());
            Console.Clear();
            if (menuOption == 1)
            {
                CalculateCostIncrease();
            }
            else if (menuOption == 2 )
            {
                CalculateInventory();

            }
            else if (menuOption == 3)
            {
                CalculatePropertyTax();
            }
            else if (menuOption == 4)
            {
                Environment.Exit(0);
            }
        }

        private static void CalculateCostIncrease()
        {
            Console.Title = "Calculate Cost Increase";
            //declare variables
            double percentIncrease;
            double ogPrice;
            double priceIncrease;
            double newPrice;
                //get input
            Console.Write($"{"What is the percent increase:",-32}");
            percentIncrease = double.Parse(Console.ReadLine())/100;
            Console.Write($"{"What is the Original Price:",-32}");
            ogPrice = double.Parse(Console.ReadLine());
            
            //calculate
            priceIncrease = ogPrice * percentIncrease;
            newPrice = priceIncrease + ogPrice;

            //Display
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n{"The price increase is",-23}{priceIncrease,8:c}");
            Console.WriteLine($"\n{"The new price is",-23}{newPrice,8:c}");
            ReturnToMenu();
        }
        private static void CalculateInventory()
        {
            Console.Title = "Inventory calculation";
            //declare variables
            int ogInvAmount;
            int amountSold;
            int amountReturned;
            int endInvAmount;

            //got input
            Console.Write($"{"What is the Original Inventory amount:",-42}");
            ogInvAmount = int.Parse(Console.ReadLine());
            Console.Write($"{"How much were sold:",-42}");
            amountSold = int.Parse(Console.ReadLine());
            Console.Write($"{"How much were returned:",-42}");
            amountReturned = int.Parse(Console.ReadLine());

            //calculations
            endInvAmount = ogInvAmount + amountReturned - amountSold;

            //Output
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nThe amount that you have is {endInvAmount}");
            
            ReturnToMenu();

        }
        private static void CalculatePropertyTax()
        {
            Console.Title = "Calculate Property Tax";
            
            //declare variables
            double propertyValue;
            double taxRate;
            const double TAX_DENOMINATOR = 100;
            double annualPropTax;


            //get input
            Console.Write($"{"What is the property value:",-31}");
            propertyValue = double.Parse(Console.ReadLine());
            Console.Write($"{"What is the tax rate:",-31}");
            taxRate = double.Parse(Console.ReadLine());

            //calculations
            annualPropTax = (propertyValue / TAX_DENOMINATOR) * taxRate;

            //output
            Console.ForegroundColor = ConsoleColor.Green;
            string output = $"Your annual property Tax is {annualPropTax:c2}";
            Console.WriteLine($"\n{output}");
            ReturnToMenu();

        }
        private static void ReturnToMenu()
        {

            Console.ResetColor();
            Console.WriteLine("\nPress <Enter> to return to Menu...");
            Console.ReadKey();
            Console.Clear();
            DisplayMenu();

        }

    }
}
