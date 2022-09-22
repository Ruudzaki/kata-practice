using System.Collections.Generic;
using Greed.Application;
using NUnit.Framework;

namespace Greed.Test
{
    public class GreedServiceTest
    {

        [Test]
        public void RollDices_5_ListOf5Numbers()
        {
            var service = new GreedService();

            IList<int> numbers = service.RollDices();

            Assert.AreEqual(5, numbers.Count);
        }
    }
}