using FizzBuzz.Core;

IFizzBuzz fizzBuzz = FizzBuzzFactory.Create();

IEnumerable<string> numbers = fizzBuzz.GetNumbers();

foreach (var number in numbers)
{
    Console.WriteLine(number);
}

Console.ReadKey(); //pause
