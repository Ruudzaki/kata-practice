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

        public FizzBuzz(Predicate<int> isFizz)
        {
            _isFizz = isFizz;
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

                numbers.Add(i.ToString());
            }

            return numbers;
        }
    }
}
