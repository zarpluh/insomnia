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
            if((a>b)&&(a>c)&&(b>c)) {Console.WriteLine("{0} {1} {2}",a,b,c);}
            if((b>c)&&(b>a)&&(c>a)) {Console.WriteLine("{0} {1} {2}",b,c,a);}
            if((a>c)&&(a>b)&&(c>b)) {Console.WriteLine("{0} {1} {2}",a,c,b);}
            if((b>a)&&(a>c)&&(b>c)) {Console.WriteLine("{0} {1} {2}",b,a,c);}
            if((c>a)&&(a>b)&&(c>b)) {Console.WriteLine("{0} {1} {2}",c,a,b);}
            if((c>b)&&(b>a)&&(c>a)) {Console.WriteLine("{0} {1} {2}",c,b,a);}
        }
    }
}
