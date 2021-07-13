using System;

namespace exercise1_miles_per_gallon
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputMiles;
            string inputGallons;
            double miles;
            double gallons;
            double mpg;
            


            Console.WriteLine("How many miles you drove?");
            inputMiles = Console.ReadLine();
            miles = double.Parse(inputMiles);

            Console.WriteLine("How much gas (in gallons) was used?");
            inputGallons = Console.ReadLine();
            gallons = double.Parse(inputGallons);

            mpg = miles / gallons;
            Console.WriteLine("Your car's average miles per gallon is " + mpg +"mpg");
        }
    }
}
