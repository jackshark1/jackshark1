/*  Author: Jackson Westphall
 *  Date:   11/05/2025
 *  Description: fizz buzz yay
 */
using static System.Console;

namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MakeFizzBuzz();
            MakeFizzBuzzV2();
            ReadKey();
        }
        internal static void MakeFizzBuzz()
        {

            for (int num = 1; num <= 100; num++)
            {
                if (num % 15 == 0)
                {
                    WriteLine($"FizzBuzz");
                }
                else if (num % 3 == 0)
                {
                    WriteLine("Fizz");
                }
                else if (num % 5 == 0)
                {
                    WriteLine("Buzz");
                }
                else
                {
                    WriteLine($"{num}");
                }
            }
        }
        internal static void MakeFizzBuzzV2()
        {
            

            for (int num = 1; num <= 100; num++)
                WriteLine($"{(num % 15 == 0 ? "FizzBuzz" : num % 3 == 0 ? "Fizz" : num % 5 == 0 ? "Buzz" : $"{num}")}");
             
        }
    }
}
