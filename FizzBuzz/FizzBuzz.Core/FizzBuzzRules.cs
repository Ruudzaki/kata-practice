using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Core
{
    public static class FizzBuzzRules
    {
        public static bool IsFizz(int number)
        {
            return IsDivisibleBy3(number) || IsContaining3(number);
        }

        public static bool IsBuzz(int number)
        {
            return IsDivisibleBy5(number);
        }

        private static bool IsDivisibleBy3(int number)
        {
            return number % 3 == 0;
        }

        private static bool IsDivisibleBy5(int number)
        {
            return number % 5 == 0;
        }

        private static bool IsContaining3(int number)
        {
            foreach (var digit in number.ToString())
            {
                if (digit == '3') return true;
            }

            return false;
        }
    }
}
