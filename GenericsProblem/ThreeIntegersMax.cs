using System;

namespace GenericsProblem
{
    public class ThreeIntegersMax
    {
        public void FindIntNumber(int a, int b, int c)
        {
            if (a >= b && a >= c)
            {
                Console.WriteLine("a is max");
            }
            else if (b >= a && b >= c)
            {
                Console.WriteLine("b is max");
            }
            else if (c >= a && c >= b)
            {
                Console.WriteLine("c is max");
            }
            else
            {
                Console.WriteLine("Two or more integers are equal to the maximum value.");
            }
        }
    }
}
