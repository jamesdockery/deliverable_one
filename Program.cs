using System;
using System.Globalization;

namespace CurrencyConverter
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Double amount1;
            Double amount2;
            Double amount3;



            Console.WriteLine("Welcome to the Currency Converter! Please enter three amounts to be converted!");

            //Take in and read each number input

            Console.Write("1st Amount: ");
            amount1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("2nd Amount: ");
            amount2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("3rd Amount: ");
            amount3 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("You have enetered " + amount1 + ", " + amount2 + " and " + amount3);


            // Each Number will be added, then given an average, largest, and smallest value
            Double average = (amount1 + amount2 + amount3) / 3;
            Console.WriteLine("The Average: " + average);


            // Largest Value
            if (amount1 >= amount2 && amount1 >= amount3)
            {
                Console.WriteLine("The Largest value: " + amount1);

            } else if (amount2 >= amount1 && amount2 >= amount3)
            {
                Console.WriteLine("The Largest value: " + amount2);

            } else
            {
                Console.WriteLine("The Largest value: " + amount3);

            }

            // Smallest Value

            if (amount1 <= amount2 && amount1 <= amount3)
            {
                Console.WriteLine("The Smallest value: " + amount1);

            } else if (amount2 <= amount1 && amount2 <= amount3)
            {
                Console.WriteLine("The Smallest value: " + amount2);

            } else
            {
                Console.WriteLine("The Smallest value: " + amount3);

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
            Console.WriteLine("Japanese: " + sum.ToString("C", CultureInfo.CreateSpecificCulture("ja-JP")));

            // Thai Bhet
            Console.WriteLine("Thai: "  + sum.ToString("C", CultureInfo.CreateSpecificCulture("th-TH")));

        }



    }
}



