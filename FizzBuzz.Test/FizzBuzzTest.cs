using System.Collections.Generic;
using NUnit.Framework;


namespace FizzBuzz.Test
{
    public class FizzBuzzTest
    {

        [Test]
        public void GetNumbers_NoParameters_ListOfIntFrom0to100()
        {
            var fizzBuzz = new Application.FizzBuzz();

            var expectedNumbers = new List<int>();

            for (int i = 0; i < 100; i++)
            {
                expectedNumbers.Add(i);
            }

            IEnumerable<int> actual = fizzBuzz.GetNumbers();

            CollectionAssert.AreEqual(expectedNumbers, actual);
        }
    }
}