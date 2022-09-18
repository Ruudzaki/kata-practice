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
            fizzBuzz = new FizzBuzzFizz();
        }

        public IEnumerable<string> GetNumbers()
        {
            return fizzBuzz.GetNumbers();
        }
    }
}
