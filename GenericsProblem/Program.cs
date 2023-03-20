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

            Console.WriteLine("Test case 2 (floats):");
            maxFinder.FindMaxFloatNumber(10.2f, 5.6f, 8.7f);


            Console.ReadLine();
        }
    }
}
