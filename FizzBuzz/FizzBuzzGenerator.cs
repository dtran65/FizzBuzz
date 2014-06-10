namespace FizzBuzz
{
    public class FizzBuzzGenerator
    {
        private IConsole _console;
        public FizzBuzzGenerator(IConsole console)
        {
            _console = console ?? new Printer();
        }

        public void Start()
        {
            for (int i = 1; i <= 100; i++)
            {
                var multipleOfThree = i % 3;
                var multipleOfFive = i % 5;

                if(multipleOfThree == 0 && multipleOfFive == 0)
                    _console.Print("FizzBuzz");
                else if (multipleOfThree == 0)
                    _console.Print("Fizz");
                else if (multipleOfFive == 0)
                    _console.Print("Buzz");
                else
                    _console.Print(i.ToString());
            }
        }
    }
}