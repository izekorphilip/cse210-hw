using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");

        public class Person
        {
            
            public string _givenName = "Jonh";
            public string _familyName = "peter";

            public Person ()
            {

            }
            public void ShowEasternName()
            {
                Console.WriteLine($"{_givenName} {_familyName}");
            }
            Person.ShowEasternName()
        }
    }
}