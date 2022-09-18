using FizzBuzz.Core;

IFizzBuzz fizzBuzz = new FizzBuzzProxy();

var numbers = fizzBuzz.GetNumbers();

foreach (var number in numbers)
{
    Console.WriteLine(number);
}

Console.ReadKey(); //pause
