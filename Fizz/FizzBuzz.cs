namespace Fizz
{
    public class FizzBuzz
    {
        public List<string> GetFizzBuzzSequence(int from, int till)
        {
            var list = new List<string>();

            for (int i = from; i <= till; i++)
            {
                var result = string.Empty;

                if (i % 3 == 0)
                    result += "Fizz";

                if (i % 5 == 0)
                    result += "Buzz";

                if (string.IsNullOrEmpty(result))
                {
                    result = i.ToString();
                }

                list.Add(result);
            }

            return list;
        }
    }
}
