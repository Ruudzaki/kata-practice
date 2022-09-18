using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Core
{
    public class FizzBuzzFizz : IFizzBuzz
    {
        public IEnumerable<string> GetNumbers()
        {
            var numbers = new List<string>();

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
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
