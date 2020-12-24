using System;
public class MatrixSpiral
{
    static void Main()
    {
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("k = ");
        int k = int.Parse(Console.ReadLine());
        for (int i = n - 1; i > 0; i--)
        {
            n *= i;
        }

        for (int i = k - 1; i > 0; i--)
        {
            k *= i;
        }

        n /= k;
        Console.WriteLine("Result is {0}", n);
    }
}
