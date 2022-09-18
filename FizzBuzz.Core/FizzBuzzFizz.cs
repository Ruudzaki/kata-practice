using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Core
{
    public class FizzBuzzFizz : IFizzBuzz
    {
        private readonly Predicate<int> _isFizzPredicate;

        public FizzBuzzFizz(Predicate<int> isFizz)
        {
            _isFizzPredicate = isFizz;
        }
        public IEnumerable<string> GetNumbers()
        {
            var numbers = new List<string>();

            for (int i = 1; i <= 100; i++)
            {
                if (IsFizz(i))
                {
                    numbers.Add("Fizz");
                    continue;
                }

                numbers.Add(i.ToString());
            }

            return numbers;
        }

        private bool IsFizz(int i)
        {
            return _isFizzPredicate.Invoke(i);
        }
    }
}
