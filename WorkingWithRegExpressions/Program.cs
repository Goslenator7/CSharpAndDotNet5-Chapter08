using System;
using static System.Console;
using System.Text.RegularExpressions;

namespace WorkingWithRegExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Enter your age: ");
            string input = ReadLine();

            //var ageChecker = new Regex(@"\d"); 
            //@ removes escape characters e.g. \n = new line
            // note, since we use \d this is valid for one digit. If we enter bob30 it would still be accepted, as there
            // are no rules asking for exclusively a digit

            var ageChecker = new Regex(@"^\d+$");

            if (ageChecker.IsMatch(input))
            {
                WriteLine("Thank you!");
            }
            else
            {
                WriteLine($"This is not a valid age: {input}");
            }

            string films = "\"Monsters, Inc.\",\"I, Tonya\",\"Lock, Stock and Two Smoking Barrels\"";

            string[] filmsDumb = films.Split(',');
            WriteLine("Dumb attempt at splitting");
            foreach (string film in filmsDumb)
            {
                WriteLine(film);
            }

            var csv = new Regex("(?:^|,)(?=[^\"]|(\")?)\"?((?(1)[^\"]*|[^,\"]*))\"?(?=,|$)");

            MatchCollection filmsSmart = csv.Matches(films);

            WriteLine("Smart attemp at splitting:");
            foreach (Match film in filmsSmart)
            {
                WriteLine(film.Groups[2].Value);
            }
        }
    }
}
