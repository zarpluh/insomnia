using System;
using System.Linq;

namespace OddAndEvenProducts
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int oddProduct = 1;
            int evenProduct = 1;
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    oddProduct *= numbers[i];
                }
                else
                {
                    evenProduct *= numbers[i];
                }
            }
            if (evenProduct == oddProduct)
            {
                Console.WriteLine($"yes {oddProduct}");
            }
            else
            {
                Console.WriteLine($"no {evenProduct} {oddProduct}");
            }
        }
    }
}
