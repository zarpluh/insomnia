using System;
//Chapter3. Task13
class GFG
{

    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int v = int.Parse(Console.ReadLine());
        if((v!=0)&&(v!=1))
        {
            Console.WriteLine("Wromg input!");
        }
        else
            if(v==0)
            {
                    n &= ~(1 << p);
                    Console.WriteLine(n);
            }
            else
                if(v==1)
                {
                    n = n | (1 << p);
                    Console.WriteLine(n);
                }
    }
}
