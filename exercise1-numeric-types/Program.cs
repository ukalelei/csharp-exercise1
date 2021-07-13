using System;

namespace exercise1_numeric_types
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLength;
            string inputWidth;
            double length;
            double width;
            double area;

            Console.WriteLine("What is the length of the rectangle?");
            inputLength = Console.ReadLine();
            length = double.Parse(inputLength);

            Console.WriteLine("What is the width of the rectangle?");
            inputWidth = Console.ReadLine();
            width = double.Parse(inputWidth);

            area = length * width;
            Console.WriteLine("The area of your rectangle is " + area);

        }
       
    }
}
