using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");
        Console.Write("What is you first name? ");
        string firstname = Console.ReadLine();
        Console.Write("What is you last name? ");
        string lastname = Console.ReadLine();
        Console.WriteLine($"Your name is {lastname}, {firstname} {lastname}.");
    }
}