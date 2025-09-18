Link: https://leetcode.com/problems/number-of-strings-that-appear-as-substrings-in-word/
Language: C#







public class Solution {
        public int NumOfStrings(string[] patterns, string word)
        {
            int counter = 0;

            for (int i = 0; i < patterns.Length; i++)
            {
                if (word.Contains(patterns[i]))
                    counter++;
            }
            
            return counter;
        }
}