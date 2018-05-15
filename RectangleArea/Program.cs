using System;

namespace RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int length;
            int height;
            string input;
            int result;

            Console.WriteLine("What is the length of the rectangle?");
            input = Console.ReadLine();
            length = int.Parse(input);
            Console.WriteLine("What is the height of the rectangle?");
            input = Console.ReadLine();
            height = int.Parse(input);
            result = length * height;
            Console.WriteLine("The area of the rectangle is " + result);
            Console.ReadLine();
        }
    }
}
