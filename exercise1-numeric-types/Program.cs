using System;

namespace exercise1_numeric_types
{
    class Program
    {
        static void Main(string[] args)
        {
            string InputLength;
            string InputWidth;
            double length;
            double width;
            double area;

            Console.WriteLine("What is the length of the rectangle?");
            InputLength = Console.ReadLine();
            length = double.Parse(InputLength);

            Console.WriteLine("What is the width of the rectangle?");
            InputWidth = Console.ReadLine();
            width = double.Parse(InputWidth);

            area = length * width;
            Console.WriteLine("The area of your rectangle is " + area);

        }
       
    }
}
