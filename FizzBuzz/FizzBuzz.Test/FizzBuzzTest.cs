using System.Collections.Generic;
using System.Linq;
using FizzBuzz.Core;
using NUnit.Framework;


namespace FizzBuzz.Test
{
    public class FizzBuzzTest
    {
        [Test]
        public void SimpleGetNumbers_NoParameters_ListOfIntFrom1to100()
        {
            IFizzBuzz fizzBuzz = new FizzBuzzSimple();
            IEnumerable<string> expectedNumbers = GetExpectedNumbers();

            IEnumerable<string> actual = fizzBuzz.GetNumbers();

            CollectionAssert.AreEqual(expectedNumbers, actual);
        }

        [TestCase(3)]
        [TestCase(6)]
        public void ProxyGetNumbers_NoParameters_Each3rdIsFizz(int i)
        {
            IFizzBuzz fizzBuzz = new FizzBuzzProxy();

            IEnumerable<string> actual = fizzBuzz.GetNumbers();

            Assert.AreEqual("Fizz", actual.ToArray()[--i]);
        }

        [TestCase(5)]
        [TestCase(10)]
        public void ProxyGetNumbers_NoParameters_Each5thIsBuzz(int i)
        {
            IFizzBuzz fizzBuzz = new FizzBuzzProxy();

            IEnumerable<string> actual = fizzBuzz.GetNumbers();

            Assert.AreEqual("Buzz", actual.ToArray()[--i]);
        }

        private static List<string> GetExpectedNumbers()
        {
            var expectedNumbers = new List<string>();

            for (int i = 1; i <= 100; i++)
            {
                expectedNumbers.Add(i.ToString());
            }

            return expectedNumbers;
        }
    }
}