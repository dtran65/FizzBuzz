using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        private static IConsole _console;

        static void Main(string[] args)
        {
            var fizzBuzzGenerator = new FizzBuzzGenerator(_console);

            Console.WriteLine("Welcome to FizzBuzz!\n");
            Console.WriteLine("Starting FizzBuzz...\n");
            fizzBuzzGenerator.Start();

            Console.ReadKey();
        }
    }
}
