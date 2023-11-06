using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
         List<int> words = new List<int>();
        int num = -1;

        while (num != 0)
        {
            Console.Write("What is your number? ");
            string userResponse = Console.ReadLine();
            num = int.Parse(userResponse);

            if (num != 0)
            {
                words.Add(num);
            } 
        }
        int sum = 0; 
        foreach ( int word in words)
        {
            sum += word;
        }
         Console.WriteLine($"This is the {sum}");
         Console.WriteLine(words.Count);

        float averageNumber = ((float)sum)/ words.Count;
        Console.WriteLine(averageNumber);

        int h = words[0];

        foreach (int word in words)
        {
            if (word < h)
            {
                // if this number is greater than the max, we have found the new max!
                h = word;
            }
        }

        Console.WriteLine($"The max is: {h}");
       words.Sort();
       foreach ( int word in words)
       {
            Console.WriteLine(word);
       }
    }
}