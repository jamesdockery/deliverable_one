using System;
using System.Globalization;

namespace CurrencyConverter
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Currency Converter! Please enter three amounts to be convertered!");

            // First amount to be taken
            Double amount1;

            Console.WriteLine("Amount1:");

            amount1 = Convert.ToDouble(Console.ReadLine());

            // Second amount to be taken
            Double amount2;

            Console.WriteLine("Amount2:");

            amount2 = Convert.ToDouble(Console.ReadLine());

            // Third amount to be taken
            Double amount3;

            Console.WriteLine("Amount3:");


            amount3 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("You have enetered " + amount1 + " and " + amount2 + " and " + amount3);


            // Each Number will be added, then given an average, largest, and smallest value

            Double average = (amount1 + amount2 + amount3) / 3;

            Console.WriteLine("Average: " + average);

            // Largest Value
            if (amount1 >= amount2 && amount1 >= amount3)
            {
                Console.WriteLine("Largest value: " + amount1);

            } else if (amount2 >= amount1 && amount2 >= amount3)
            {
                Console.WriteLine("Largest value: " + amount2);

            } else
            {
                Console.WriteLine("Largest value: " + amount3);

            }

            // Smallest Value

            if (amount1 <= amount2 && amount1 <= amount3)
            {
                Console.WriteLine("Smallest value: " + amount1);

            } else if (amount2 <= amount1 && amount2 <= amount3)
            {
                Console.WriteLine("Smallest value: " + amount2);

            } else
            {
                Console.WriteLine("Smallest value: " + amount3);

            }

            //Currency Converter
            Console.WriteLine("Currency Conversion Below: " +
            	"" );

            Double sum = amount1 + amount2 + amount3;

            //American Dollar
            Console.WriteLine("US: " + sum.ToString("C", CultureInfo.CurrentCulture));

            // Swedish
            Console.WriteLine("Swedish: " + sum.ToString("C", CultureInfo.CreateSpecificCulture("sv-SE")));


            // Japanese Yen
            Console.WriteLine("Japanese " + sum.ToString("C", CultureInfo.CreateSpecificCulture("ja-JP")));

            // Thai Bhet
            Console.WriteLine("Thai: " + sum.ToString("C", CultureInfo.CreateSpecificCulture("th-TH").NumberFormat));

        }



    }
}



