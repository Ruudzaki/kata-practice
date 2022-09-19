using System.Collections.Generic;
using System.Linq;
using FizzBuzz.Core;
using NUnit.Framework;


namespace FizzBuzz.Test
{
    public class FizzBuzzTest
    {

        [TestCase(3)]
        [TestCase(6)]
        public void GetNumbers_NoParameters_Each3rdIsFizz(int i)
        {
            IFizzBuzz fizzBuzz = new Core.FizzBuzz(FizzBuzzRules.IsFizz, FizzBuzzRules.IsBuzz);

            IEnumerable<string> actual = fizzBuzz.GetNumbers();

            Assert.AreEqual("Fizz", actual.ToArray()[--i]);
        }

        [TestCase(5)]
        [TestCase(10)]
        public void GetNumbers_NoParameters_Each5thIsBuzz(int i)
        {
            IFizzBuzz fizzBuzz = new Core.FizzBuzz(FizzBuzzRules.IsFizz, FizzBuzzRules.IsBuzz);

            IEnumerable<string> actual = fizzBuzz.GetNumbers();

            Assert.AreEqual("Buzz", actual.ToArray()[--i]);
        }

        [TestCase(15)]
        [TestCase(30)]
        public void GetNumbers_NoParameters_Each15thIsFizzBuzz(int i)
        {
            IFizzBuzz fizzBuzz = new Core.FizzBuzz(FizzBuzzRules.IsFizz, FizzBuzzRules.IsBuzz);

            IEnumerable<string> actual = fizzBuzz.GetNumbers();

            Assert.AreEqual("FizzBuzz", actual.ToArray()[--i]);
        }

        [TestCase(13)]
        [TestCase(23)]
        public void GetNumbers_NoParameters_EachContains3IsFizz(int i)
        {
            IFizzBuzz fizzBuzz = new Core.FizzBuzz(FizzBuzzRules.IsFizz, FizzBuzzRules.IsBuzz);

            IEnumerable<string> actual = fizzBuzz.GetNumbers();

            Assert.AreEqual("Fizz", actual.ToArray()[--i]);
        }

        [TestCase(52)]
        [TestCase(56)]
        public void GetNumbers_NoParameters_EachContains5IsBuzz(int i)
        {
            IFizzBuzz fizzBuzz = new Core.FizzBuzz(FizzBuzzRules.IsFizz, FizzBuzzRules.IsBuzz);

            IEnumerable<string> actual = fizzBuzz.GetNumbers();

            Assert.AreEqual("Buzz", actual.ToArray()[--i]);
        }

        [TestCase(53)]
        public void GetNumbers_NoParameters_EachContains5And3IsFizzBuzz(int i)
        {
            IFizzBuzz fizzBuzz = new Core.FizzBuzz(FizzBuzzRules.IsFizz, FizzBuzzRules.IsBuzz);

            IEnumerable<string> actual = fizzBuzz.GetNumbers();

            Assert.AreEqual("FizzBuzz", actual.ToArray()[--i]);
        }
    }
}