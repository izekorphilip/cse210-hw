using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your magic number? ");
        string magic = Console.ReadLine();
        int magicNumber = int.Parse(magic);

        int guesses = -1;
        while (magicNumber != guesses)
        {   
            Console.Write("What is your guess number? ");
            string userResponse = Console.ReadLine();
            guesses = int.Parse(userResponse) ;

            if (guesses < magicNumber)
            {
                Console.WriteLine ("Higher"); 
            }
            else if (guesses > magicNumber)
            {
                Console.WriteLine ("Lower"); 
            }
            else 
            {
                Console.WriteLine("You guessed it"); 
            }
        }  
    }
}