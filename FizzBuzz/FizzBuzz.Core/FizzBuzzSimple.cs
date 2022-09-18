namespace FizzBuzz.Core
{
    public class FizzBuzzSimple : IFizzBuzz
    {
        public IEnumerable<string> GetNumbers()
        {
            var numbers = new List<string>();

            for (int i = 1; i <= 100; i++)
            {
                numbers.Add(i.ToString());
            }

            return numbers;
        }
    }
}
