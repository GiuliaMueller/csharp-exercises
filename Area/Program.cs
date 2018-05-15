using System;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            double radius;
            double area;

            Console.WriteLine("What is the radius?");
            input = Console.ReadLine();
            radius = double.Parse(input);

            if (radius < 0)
            {
                Console.WriteLine("radius must be greater than zero");
                Console.ReadLine();

            }
            else
            {
                area = 3.14 * radius * radius;
                Console.WriteLine("The area of a circle with radius " + radius + " is: " + area + "!");
                Console.ReadLine();
            }
            
        }
    }
}
