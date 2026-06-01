Link: https://leetcode.com/problems/count-the-number-of-special-characters-ii/
Language: C#








public class Solution {
        public int NumberOfSpecialChars(string word)
        {
            int[] capitals = new int[26];

            for (int i = word.Length - 1; i >= 0; i--)
            {
                if (word[i] <= 'Z')
                    capitals[word[i] - 'A'] = i;
            }

            int counter = 0;

            for (int i = word.Length - 1; i >= 0; i--)
            {
                if (word[i] >= 'a')
                {
                    if (i < capitals[word[i] - 32 - 'A'])
                        counter++;
                    capitals[word[i] - 32 - 'A'] = 0;
                }
            }

            return counter;
        }
}