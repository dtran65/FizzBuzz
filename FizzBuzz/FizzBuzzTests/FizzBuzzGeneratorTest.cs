using FizzBuzz;
using NUnit.Framework;
using Rhino.Mocks;
using Is = Rhino.Mocks.Constraints.Is;

namespace FizzBuzzTests
{
    [TestFixture]
    public class FizzBuzzGeneratorTest
    {
        private IConsole _console;

        [Test]
        public void FizzBuzzGeneratorShouldPrintValues100Times()
        {
            // Arrange
            _console = MockRepository.GenerateMock<IConsole>();
            var generator = new FizzBuzzGenerator(_console);
            _console.Expect(x => x.Print(Arg<string>.Is.Anything)).Repeat.Times(100);

            // Act
            generator.Start();

            // Assert
            _console.VerifyAllExpectations();
        }

        [Test]
        public void FizzBuzzGeneratorShouldPrintFizzForMultiplesOfThree()
        {
            // Arrange
            _console = MockRepository.GenerateMock<IConsole>();
            var generator = new FizzBuzzGenerator(_console);
            _console.Expect(x => x.Print(Arg<string>.Matches(Is.Equal("Fizz")))).Repeat.AtLeastOnce();

            // Act
            generator.Start();

            // Assert
            _console.VerifyAllExpectations();
        }

        [Test]
        public void FizzBuzzGeneratorShouldPrintBuzzForMultiplesOfFive()
        {
            // Arrange
            _console = MockRepository.GenerateMock<IConsole>();
            var generator = new FizzBuzzGenerator(_console);
            _console.Expect(x => x.Print(Arg<string>.Matches(Is.Equal("Buzz")))).Repeat.AtLeastOnce();

            // Act
            generator.Start();

            // Assert
            _console.VerifyAllExpectations();
        }

        [Test]
        public void FizzBuzzGeneratorShouldPrintFizzBuzzForMultiplesOfThreeAndFive()
        {
            // Arrange
            _console = MockRepository.GenerateMock<IConsole>();
            var generator = new FizzBuzzGenerator(_console);
            _console.Expect(x => x.Print(Arg<string>.Matches(Is.Equal("FizzBuzz")))).Repeat.AtLeastOnce();

            // Act
            generator.Start();

            // Assert
            _console.VerifyAllExpectations();
        }
    }
}
