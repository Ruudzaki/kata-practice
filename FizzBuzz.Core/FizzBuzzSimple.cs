namespace FizzBuzz.Core
{
    public class FizzBuzzSimple : IFizzBuzz
    {
        public IEnumerable<int> GetNumbers()
        {
            var numbers = new List<int>();

            for (int i = 1; i <= 100; i++)
            {
                numbers.Add(i);
            }

            return numbers;
        }
    }
}
