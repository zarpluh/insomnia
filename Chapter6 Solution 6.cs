using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2011;
            int b = 1990;
            Console.WriteLine("Greater: {0}", (a + b + Math.Abs(a - b)) / 2);
            Console.WriteLine("Smaller: {0}", (a + b - Math.Abs(a - b)) / 2);
        }
    }
}
