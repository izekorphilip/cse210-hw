using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
         Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int number = int.Parse(grade);
        string letter = "";
        if (number >= 90)
        {
            letter = "A";
        }
        else if (number >= 80 && number < 90)
        {
            letter = "B";
        }
         else if (number >= 70 && number < 80)
        {
            letter = "C";
        }
         else if (number >= 60 && number < 70)
        {
            letter = "D";
        }
         else if (number < 60)
        {
            letter = "F";
        }
        Console.WriteLine($"Your grade is {letter}");
        if (number >= 70)   
        {
           Console.WriteLine("You passed");
        }
        else
        {
            Console.WriteLine("Better luck next time");
        }

    }
}