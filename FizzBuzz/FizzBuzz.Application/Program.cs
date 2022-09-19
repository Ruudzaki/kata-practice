using FizzBuzz.Core;

IFizzBuzz fizzBuzz = new FizzBuzz.Core.FizzBuzz(FizzBuzzRules.IsFizz, FizzBuzzRules.IsBuzz);

IEnumerable<string> numbers = fizzBuzz.GetNumbers();

foreach (var number in numbers)
{
    Console.WriteLine(number);
}

Console.ReadKey(); //pause
