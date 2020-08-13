using System;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your age? ");
            string ageAsString = Console.ReadLine();
            int age = int.Parse(ageAsString);

            if (age > 21)
            {
                Console.WriteLine("You are an adult");
            }
            else
            {
                Console.WriteLine("You are not yet a legal adult.");
            }
        }
    }
}