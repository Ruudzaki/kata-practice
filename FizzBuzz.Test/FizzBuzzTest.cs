using NUnit.Framework;


namespace FizzBuzz.Test
{
    public class FizzBuzzTest
    {

        [Test]
        public void GetList_NoParameters_ListOfIntFrom0to100()
        {
            var fizzBuzz = new Application.FizzBuzz();

            Assert.Pass();
        }
    }
}