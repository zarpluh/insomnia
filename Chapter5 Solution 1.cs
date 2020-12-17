using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse((Console.ReadLine()));
            int b = int.Parse((Console.ReadLine()));
            int value = 0;
            if (a > b)
            {
                value = a;
                a = b;
                b= value;
            }

            Console.WriteLine("{0} {1}",a, b);
        }
    }
}
