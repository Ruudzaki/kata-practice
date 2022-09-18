using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Application
{
    public class FizzBuzz
    {
        public IEnumerable<int> GetNumbers()
        {
            var numbers = new List<int>();

            for (int i = 0; i < 100; i++)
            {
                numbers.Add(i);
            }

            return numbers;
        }
    }
}
