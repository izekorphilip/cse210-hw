using System;

class Program
{
    static void Main(string[] args)
    {

        //In this program file, I created an instance of the History class, accept user input
        // to determine which history to execute, and execute the history using polymorphism.

        Console.WriteLine("Please enter one of the number 1 to 7");
        Console.WriteLine("1. For Story");
        Console.WriteLine("2. For Recent Updates");
        Console.WriteLine("3. For Past Updates");
        Console.WriteLine("4. For Nigeria Updates");
        Console.WriteLine("5. For Scriptures");
        Console.WriteLine("6. For Magazine Latest News");
        Console.WriteLine("7. For Lds Latest News");
        Console.WriteLine();
        Console.Write("Chose a Number ");
        string userInput = Console.ReadLine();

        Histories history;

       if (userInput == "1")
        {
            history = new Story();
        }
        else if (userInput == "2")
        {
            history = new RecentUpdates();
        }
        else if (userInput == "3")
        {
            history = new PastUdates();
        }
            else if (userInput == "4")
        {
            history = new NigeriaUpdate();
        }
            else if (userInput == "5")
        {
            history = new Scriptures();
        }
            else if (userInput == "6")
        {
            history = new MagazineLatestNews();
        }
            else if (userInput == "7")
        {
            history = new LdsLatestNews();
        }
        else
        {
            Console.WriteLine("Invalid input. Exiting program.");
            return;
        }

        history.History();
    }
}   