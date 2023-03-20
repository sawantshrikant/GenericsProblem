using System;

namespace GenericsProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Three Integers Max program!");

            ThreeIntegersMax maxFinder = new ThreeIntegersMax();

            
            Console.WriteLine("Test case 1:");
            maxFinder.FindIntNumber(10, 5, 2);

            
            Console.WriteLine("Test case 2:");
            maxFinder.FindIntNumber(5, 10, 2);

            
            Console.WriteLine("Test case 3:");
            maxFinder.FindIntNumber(5, 2, 10);

            Console.ReadLine();
        }
    }
}
