using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            Console.Write("Please type your first name: ");
            string myFirstName = Console.ReadLine();

            Console.Write("Please type your last name: ");
            string myLastName = Console.ReadLine();

            Console.WriteLine("Hello, " + myFirstName + " " + myLastName + "!");
            Console.ReadLine();


        }
    }
}
