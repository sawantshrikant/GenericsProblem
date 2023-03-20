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
        public void FindMaxFloatNumber(float a, float b, float c)
        {
            if (a >= b && a >= c)
                Console.WriteLine("a is max");
            else if (b >= a && b >= c)
                Console.WriteLine("b is max");
            else if (c >= a && c >= b)
                Console.WriteLine("c is max");
            else
            {
                Console.WriteLine("Two or more integers are equal to the maximum value.");
            }
               
        }

        public void FindMaxString(String a, String b, String c)
        {
            if (a.CompareTo(b) > 0 && a.CompareTo(c) > 0)
                Console.WriteLine("a is max");
            else if (b.CompareTo(a) > 0 && b.CompareTo(c) > 0)
                Console.WriteLine("b is max");
            else if (c.CompareTo(a) > 0 && c.CompareTo(b) > 0)
                Console.WriteLine("c is max");
            else 
            {
                Console.WriteLine("Two or more integers are equal to the maximum value.");
            }
        }

    }
}
