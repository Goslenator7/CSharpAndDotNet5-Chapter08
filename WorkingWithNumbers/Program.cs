using System;
using static System.Console;
using System.Numerics;

namespace WorkingWithNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //The largest whole num we can store in .NET
            var largest = ulong.MaxValue;
            //40 notation right-aligns 40 characters
            //N0 notation thousand seperators and 0 decimal places
            WriteLine($"{largest,40:N0}");
            //BigInteger part of the numerics library to work with even larger numbers
            var atomsInTheUniverse = BigInteger.Parse("123456789012345678901234567890");
            WriteLine($"{atomsInTheUniverse,40:N0}");
            WriteLine();
            var c1 = new Complex (4,2);
            var c2 = new Complex (3,7);
            var c3 = c1 + c2;
            WriteLine($"{c1} added to {c2} is {c3}");

        }
    }
}
