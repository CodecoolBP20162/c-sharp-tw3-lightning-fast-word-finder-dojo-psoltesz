using System.Linq;

namespace LightningFastWordFinder
{
    class LightningWordFinder
    {
        public string GetLongestWord(string text)
        {
            char[] delimiterChars = { ' ', '/', '.', '\r', '-' };

            string[] words = text.Split(delimiterChars);

            var sorted = words.OrderBy(n => n.Length);
            string longest = sorted.LastOrDefault();

            return longest;
        }
    }
}
