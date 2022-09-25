using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greed.Application
{
    public class GreedScorer
    {
        private int Score { get; set; }
        private const int SINGLE_ONE_MULTIPLIER = 100;

        public int CalculateScore(IList<int> dices)
        {
            CheckSingleOne(dices);

            return Score;
        }

        private IList<int> CheckSingleOne(IList<int> dices)
        {
            IList<int> dicesWithOnes = dices.Where(d => d == 1).ToList();

            Score += dicesWithOnes.Count() * SINGLE_ONE_MULTIPLIER;

            return dices.Except(dicesWithOnes).ToList();
        }
    }
}
