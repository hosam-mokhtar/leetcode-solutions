Link: https://leetcode.com/problems/count-the-number-of-vowel-strings-in-range/
Language: C#






public class Solution {
        public int VowelStrings(string[] words, int left, int right)
        {
            int counter = 0;
            string vowels = "aeiou";

            for (int i = left; i <= right; i++)
            {
                if (vowels.IndexOf(words[i][0]) > -1 && vowels.IndexOf(words[i][^1]) > -1)
                    counter++;
            }

            return counter;
        }
}