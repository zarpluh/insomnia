using System;

namespace ConsoleApp1
{
    class Program
    {        
        static void Main(string[] args)
        {
            char[] latinAlphabet = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 
                'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] word = (Console.ReadLine()).ToCharArray();

            for (int i = 0; i < word.Length; i++)
            
                for (int j = 0; j < latinAlphabet.Length; j++)
                
                    if (word[i] == latinAlphabet[j]) Console.Write("{0} ", j);


        }
    }
}
