using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse((Console.ReadLine()));
            int b = int.Parse((Console.ReadLine()));
            int c = int.Parse((Console.ReadLine()));
            int max = 0;
            if (a > b)
            {
                max = a;
            }
            else
            {
                max = b;
            }

            if (max > c)
            {
                Console.WriteLine(max);
            }
            else
            {
                Console.WriteLine(c);
            }
        }
    }
}
