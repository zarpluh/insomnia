using System;
//Chapter3. Task14
class GFG
{

    public static void Main()
    {

        int isPrime = int.Parse(Console.ReadLine());
        //double a = Math.Sqrt(isPrime);
        //int p = int.Parse(Console.ReadLine());
        //int mask = 0;
        //int i = mask << p;
        //Console.WriteLine((n & mask) != 0 ? "Third bit is 1" : "Third bit is 0");
        for (int i = 2; i < Math.Sqrt(isPrime); i++)
        {
            if(isPrime % i == 0)
            {
                Console.WriteLine("Number is not Prime.");
                break;
            }
            else
                Console.WriteLine("Number is Prime.");
                break;
        }
    }
}
