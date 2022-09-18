using System.Collections.Generic;
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

            var expectedNumbers = new List<int>();

            for (int i = 1; i <= 100; i++)
            {
                expectedNumbers.Add(i);
            }

            IEnumerable<int> actual = fizzBuzz.GetNumbers();

            CollectionAssert.AreEqual(expectedNumbers, actual);
        }

        [Test]
        public void ProxyGetNumbers_NoParameters_ListOfIntFrom1to100()
        {
            IFizzBuzz fizzBuzz = new FizzBuzzProxy();

            var expectedNumbers = new List<int>();

            for (int i = 1; i <= 100; i++)
            {
                expectedNumbers.Add(i);
            }

            IEnumerable<int> actual = fizzBuzz.GetNumbers();

            CollectionAssert.AreEqual(expectedNumbers, actual);
        }
    }
}