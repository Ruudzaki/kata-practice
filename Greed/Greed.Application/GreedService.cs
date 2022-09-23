namespace Greed.Application
{
    public class GreedService
    {
        public IList<int> RollDices(int count)
        {
            IList<int> numbers = new List<int>();

            for (int i = 0; i < count; i++)
            {
                var random = new Random();
                numbers.Add(random.Next(1, 6));
            }

            return numbers;
        }
    }
}