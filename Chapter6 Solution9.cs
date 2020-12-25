//Задачата е недорешена. 

using System;
public class FactorialExample
{
    public static void Main(string[] args)
    {
        //int i, fact=1 , power=1;
        //double sum = 1.0;
        //Console.Write("Enter any Number: ");
        //int n = int.Parse(Console.ReadLine());
        //Console.Write("Enter any x: ");
        //int x = int.Parse(Console.ReadLine());

        //for (i = 1; i <= n; i++)
        //{
        //    fact = fact * i;
        //    power *= x;
        //    sum = 1 + (fact / power);
        //}
        //Console.WriteLine("Factorial is: " + fact);
        //Console.WriteLine("Power is: " + power);
        //Console.WriteLine(sum);
        double sum = 1.0, temp = 1.0;
        Console.Write("Enter n: ");
        int n = Int32.Parse(Console.ReadLine());
        Console.Write("Enter x: ");
        int x = Int32.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            temp *= i / x;
            sum += temp;
        }

        Console.WriteLine("Result is {0}", sum);
    }
}
