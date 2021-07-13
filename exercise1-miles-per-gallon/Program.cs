using System;

namespace exercise1_miles_per_gallon
{
    class Program
    {
        static void Main(string[] args)
        {
            string InputMiles;
            string InputGallons;
            double miles;
            double gallons;
            double mpg;
            


            Console.WriteLine("How many miles you drove?");
            InputMiles = Console.ReadLine();
            miles = double.Parse(InputMiles);

            Console.WriteLine("How much gas (in gallons) was used?");
            InputGallons = Console.ReadLine();
            gallons = double.Parse(InputGallons);

            mpg = miles / gallons;
            Console.WriteLine("Your car's average miles per gallon is " + mpg +"mpg");
        }
    }
}
