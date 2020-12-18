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
            int value = 0;
            if ((a>0)&&(b>0)&&(c>0)){ Console.WriteLine("positive"); }
            else if ((a<0)&&(b>0)&&(c>0)){ Console.WriteLine("negative"); }
            else if ((a>0)&&(b<0)&&(c>0)){ Console.WriteLine("negative"); }
            else if ((a>0)&&(b>0)&&(c<0)){ Console.WriteLine("negative"); }
            else if ((a<0)&&(b>0)&&(c>0)){ Console.WriteLine("negative"); }
        }
    }
}
