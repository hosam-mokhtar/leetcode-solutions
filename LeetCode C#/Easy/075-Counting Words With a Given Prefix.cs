Link: https://leetcode.com/problems/counting-words-with-a-given-prefix/
Language: C#




public class Solution {
        public int PrefixCount(string[] words, string pref)
        {
            int counter = 0;
            for (int i = 0; i < words.Length; i++)
            {
                if(words[i].Length>=pref.Length)
                if (words[i].StartsWith(pref))
                    counter++;
            }
            return counter;
        }
}