using System;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How old are you? ");
            int age = int.Parse(Console.ReadLine());

            do
            {
                Console.Write("Happy Birthday ");
                age--;
            } while (age > 0);
            
            Console.WriteLine("\nTaDa!!");
        }
    }
}