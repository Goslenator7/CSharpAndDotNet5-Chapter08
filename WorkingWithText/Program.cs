using System;
using static System.Console;

namespace WorkingWithText
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = "London";
            WriteLine($"{city} is {city.Length} characters long");
            // demo the built in indexer of string class to access chars
            WriteLine($"First char is {city[0]} and third is {city[2]}");
            WriteLine();
            WriteLine("Splitting strings");
            string cities = "Paris,Berlin,Madrid,New York";
            string[] citiesArray = cities.Split(',');
            foreach (string item in citiesArray)
            {
                WriteLine(item);
            }
            string recombined = string.Join(" => ", citiesArray);
            WriteLine(recombined);

            WriteLine();
            WriteLine("Get parts of a string");
            string fullName = "Alan Jones";
            int indexOfSpace = fullName.IndexOf(' ');
            string firstName = fullName.Substring(startIndex: 0, length: indexOfSpace);
            string lastName = fullName.Substring(startIndex: indexOfSpace + 1);
            WriteLine($"{lastName}, {firstName}");

            WriteLine();
            WriteLine("Checking for content");
            string company = "Microsoft";
            bool startswithM = company.StartsWith("M");
            bool containsN = company.Contains("N");
            WriteLine($"Starts with M: {startswithM}, contains an N: {containsN}");
        }
    }
}
