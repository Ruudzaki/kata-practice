using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Greed.Application;
using NUnit.Framework;

namespace Greed.Test
{
    public class GreedScorerTest
    {
        [TestCase(new int[] {1, 2, 3, 4, 5}, ExpectedResult = 100)]
        [TestCase(new int[] { 1, 1, 3, 4, 5}, ExpectedResult = 200)]
        [TestCase(new int[] { 2, 2, 3, 4, 5}, ExpectedResult = 0)]

        public int CalculateScore(int[] dices)
        {
            var scorer = new GreedScorer();

            var score = scorer.CalculateScore(dices);

            return score;
        }
    }
}
