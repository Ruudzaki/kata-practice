using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Core
{
    public class FizzBuzzProxy : IFizzBuzz
    {
        private readonly IFizzBuzz _fizzBuzz;
        public FizzBuzzProxy()
        {
            _fizzBuzz = new FizzBuzz(IsFizz, IsBuzz);
        }

        private bool IsFizz(int i)
        {
            return i % 3 == 0;
        }

        private bool IsBuzz(int i)
        {
            return i % 5 == 0;
        }

        public IEnumerable<string> GetNumbers()
        {
            return _fizzBuzz.GetNumbers();
        }
    }
}
