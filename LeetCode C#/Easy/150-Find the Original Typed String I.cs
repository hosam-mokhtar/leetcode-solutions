Link: https://leetcode.com/problems/find-the-original-typed-string-i/
Language: C#







public class Solution {
        public int PossibleStringCount(string word)
        {
            int counter = 1;

            for (int i = 1; i < word.Length; i++)
            {
                if (word[i - 1] == word[i])
                    counter++;
            }

            return counter;
        }
}