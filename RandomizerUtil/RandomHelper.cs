namespace RandomizerUtil
{
    public class RandomHelper
    {
        private static readonly Random _random = new();

        public static int GetRandom(int len)
        {
            return _random.Next(len);
        }

        public static int GetRandom(int min, int max)
        {
            return _random.Next(min, max);
        }
    }
}
