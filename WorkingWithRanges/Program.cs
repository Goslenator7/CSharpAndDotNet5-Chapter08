using System;
using static System.Console;
using System.Collections.Generic;

namespace WorkingWithRanges
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Samantha Jones";

            int lengthOfFirst = name.IndexOf(' ');
            int lengthOfSecond = name.Length - lengthOfFirst - 1;

            string firstName = name.Substring(startIndex: 0, length: lengthOfFirst);

            string lastName = name.Substring(startIndex: name.Length - lengthOfSecond, length: lengthOfSecond);

            WriteLine($"First name: {firstName}, last name: {lastName}");

            ReadOnlySpan<char> nameAsSpan = name.AsSpan();

            var firstNameSpan = nameAsSpan[0..lengthOfFirst];

            var secondNameSpan = nameAsSpan[^lengthOfSecond..^0];

            WriteLine($"First name: {firstNameSpan.ToString()}, last name: {secondNameSpan.ToString()}");
        }
    }
}
