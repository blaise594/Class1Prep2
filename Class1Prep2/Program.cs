using System;

namespace Class1Prep2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the length of rectangle? ");
            string length = Console.ReadLine();
            int l = Convert.ToInt32(length);
            
            Console.Write("Please enter the height of rectangle? ");
            string height = Console.ReadLine();
            int h = Convert.ToInt32(height);

            int area = l * h; 
            Console.WriteLine("The area of the rectangle is " + area);
            
            Console.ReadLine();
        }
    }
}
