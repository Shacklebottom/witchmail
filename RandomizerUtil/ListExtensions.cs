
namespace RandomizerUtil
{
    public static class ListExtensions
    {
        public static void Shuffle<T>(this List<T> collection)
        {
            for (int i = collection.Count - 1; i > 0; i--)
            {
                var j = RandomHelper.GetRandom(i + 1);

                (collection[i], collection[j]) = (collection[j], collection[i]);
            }
        }
    }
}
