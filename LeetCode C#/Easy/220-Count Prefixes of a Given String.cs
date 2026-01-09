Link: https://leetcode.com/problems/count-prefixes-of-a-given-string/
Language: C#








public class Solution {
        public int CountPrefixes(string[] words, string s)
        {
            int counter = 0;

            for (int i = 0; i < words.Length; i++)
            {
                if (s.Length >= words[i].Length && s.Substring(0, words[i].Length) == words[i])
                    counter++;
            }

            return counter;
        }
}