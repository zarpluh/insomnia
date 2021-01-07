using System;
class Factorial
{
    private static long Fact(int number)
    {
        int fact = 1;
        for (int i = 1; i <= number; i++)
        {
            fact = fact* i;
        }
        return fact;
    }

    static void Main()
    {
        int number;
        Console.Write("Enter any Number: ");
        number = int.Parse(Console.ReadLine());
        for (int i = 0; i < number; i++)
        {
            Console.WriteLine("Factorial of " + i + " is: " + Fact(i));
        }
        
    }
}
