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
            fizzBuzz = new FizzBuzzSimple();
        }

        public IEnumerable<int> GetNumbers()
        {
            return fizzBuzz.GetNumbers();
        }
    }
}
