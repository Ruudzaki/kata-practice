using FizzBuzz.Core;

IFizzBuzz fizzBuzz = new FizzBuzzProxy();

IEnumerable<string> numbers = fizzBuzz.GetNumbers();

foreach (var number in numbers)
{
    Console.WriteLine(number);
}

Console.ReadKey(); //pause
