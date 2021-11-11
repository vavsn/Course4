using System;

namespace RationalNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            RatioNumbers r1 = new RatioNumbers(4, 9);
            Console.WriteLine($"r1 = {r1.ToString()}");
            RatioNumbers r2 = new RatioNumbers(3, 28);
            Console.WriteLine($"r2 = {r2.ToString()}");
            float f = 0.235F;
            Console.WriteLine($"(RatioNumbers) {f} : {(RatioNumbers)f}");
            int i = 12;
            Console.WriteLine($"(RatioNumbers) {i} : {(RatioNumbers)i}");
            Console.WriteLine($"r1 * r2 : {r1 * r2}");
            Console.WriteLine($"r1 / r2 : {r1 / r2}");
            Console.WriteLine($"r1 % r2 : {r1 % r2}");
            Console.WriteLine($"r1 + r2 : {r1 + r2}");
            Console.WriteLine($"r1 - r2 : {r1 - r2}");
            Console.WriteLine($"r1 == r2 : {r1 == r2}");
            Console.WriteLine($"r1 != r2 : {r1 != r2}");
            Console.WriteLine($"r1 ++ : {r1++}");
            Console.WriteLine($"r2 -- : {r2--}");
            Console.WriteLine($"r1- : {-r1}");
            Console.WriteLine($"r1.Equals(r2) : {r1.Equals(r2)}");
            Console.WriteLine($"r1.GetHashCode : {r1.GetHashCode()}");
            Console.WriteLine($"r2.GetHashCode : {r2.GetHashCode()}");
            Console.WriteLine($"(float)(r1 / r2) : {(float)(r1 / r2)}");
            Console.WriteLine($"(int)(r1 / r2) : {(int)(r1 / r2)}");
        }
    }
}
