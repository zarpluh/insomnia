using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int num =0;
            for (int i = a; i <= b; i++)
            {
                if ((i%5)==0)
                {

                    num = num + 1;
                }
            }
            Console.WriteLine(num);
        }
    }
}
