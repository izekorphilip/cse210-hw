using System;

class Program
{
    static void Main(string[] args)
    {

        //In this program file, I created an instance of the History class, accept user input
        // to determine which history to execute, and execute the history using polymorphism.

        Console.WriteLine("");
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