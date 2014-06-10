using System;

namespace FizzBuzz
{
    public class Printer : IConsole
    {
        public void Print(string value)
        {
            Console.WriteLine(value);
        }
    }
}