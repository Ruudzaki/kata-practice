using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Core
{
    public class FizzBuzzProxy : IFizzBuzz
    {
        private IFizzBuzz fizzBuzz;
        public FizzBuzzProxy()
        {
            fizzBuzz = new FizzBuzzFizz(IsFizz);
        }

        private bool IsFizz(int i)
        {
            return i % 3 == 0;
        }

        public IEnumerable<string> GetNumbers()
        {
            return fizzBuzz.GetNumbers();
        }
    }
}
