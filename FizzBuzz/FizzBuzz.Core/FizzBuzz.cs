using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Core
{
    public class FizzBuzz : IFizzBuzz
    {
        private readonly Predicate<int> _isFizz;
        private readonly Predicate<int> _isBuzz;

        public FizzBuzz(Predicate<int> isFizz, Predicate<int> isBuzz)
        {
            _isFizz = isFizz;
            _isBuzz = isBuzz;
        }

        public IEnumerable<string> GetNumbers()
        {
            var numbers = new List<string>();

            for (int i = 1; i <= 100; i++)
            {
                if (_isFizz.Invoke(i))
                {
                    numbers.Add("Fizz");
                    continue;
                }

                if (_isBuzz.Invoke(i))
                {
                    numbers.Add("Buzz");
                    continue;
                }

                numbers.Add(i.ToString());
            }

            return numbers;
        }
    }
}
