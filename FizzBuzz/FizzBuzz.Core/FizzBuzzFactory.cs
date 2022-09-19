using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Core
{
    public static class FizzBuzzFactory
    {
        public static FizzBuzz Create()
        {
            return new FizzBuzz(FizzBuzzRules.IsFizz, FizzBuzzRules.IsBuzz);
        }
    }
}
