using System.Collections.Generic;
using Greed.Application;
using NUnit.Framework;

namespace Greed.Test
{
    public class GreedServiceTest
    {
        
        [TestCase(5, ExpectedResult = 5)]
        public int RollDices_5_ListOf5Numbers(int count)
        {
            var service = new GreedService();

            IList<int> numbers = service.RollDices(count);

            return numbers.Count;
        }
    }
}