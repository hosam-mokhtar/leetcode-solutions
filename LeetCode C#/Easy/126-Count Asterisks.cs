Link: https://leetcode.com/problems/count-asterisks/
Language: C#






public class Solution {
        public int CountAsterisks(string s)
        {
            int countAsterisks = 0;
            int countBars = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '*' && countBars % 2 == 0)
                    countAsterisks++;
                else if (s[i] == '|')
                    countBars++;
            }
            return countAsterisks;
        }
}