using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Core
{
    public interface IFizzBuzz
    {
        public IEnumerable<int> GetNumbers();
    }
}
