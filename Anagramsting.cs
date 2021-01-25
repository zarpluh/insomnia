// C# program to check if two strings
// are anagrams of each other
using System.Collections.Generic;
using System;

class GFG
{

    static int NO_OF_CHARS = 256;

    /* function to check whether two strings
    are anagram of each other */
    static bool areAnagram(char[] str1, char[] str2)
    {
        // Create 2 count arrays and initialize
        // all values as 0
        int[] count1 = new int[NO_OF_CHARS];
        int[] count2 = new int[NO_OF_CHARS];
        int i;

        // For each character in input strings,
        // increment count in the corresponding
        // count array
        for (i = 0; i < str1.Length && i < str2.Length;
             i++)
        {
            count1[str1[i]]++;
            count2[str2[i]]++;
        }

        // If both strings are of different length.
        // Removing this condition will make the program
        // fail for strings like "aaca" and "aca"
        if (str1.Length != str2.Length)
            return false;

        // Compare count arrays
        for (i = 0; i < NO_OF_CHARS; i++)
            if (count1[i] != count2[i])
                return false;

        return true;
    }

    // Driver code
    public static void Main()
	{
		int n = int.Parse(Console.ReadLine());
        char[] str1 = ("geeksforgeeks").ToCharArray();
        char[] str2 = ("forgeeksgeeks").ToCharArray();

        // Function Call
        if (areAnagram(str1, str2))
            Console.WriteLine("The two strings are"
                              + "anagram of each other");
        else
            Console.WriteLine("The two strings are not"
                              + " anagram of each other");
    }
}

// This code is contributed by Stream_Cipher
