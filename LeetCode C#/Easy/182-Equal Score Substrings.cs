Link: https://leetcode.com/problems/equal-score-substrings/
Language: C#







public class Solution {
        public bool ScoreBalance(string s)
        {
            int totalScore = 0;

            for (int i = 0; i < s.Length; i++)
            {
                totalScore += (s[i] - 'a' + 1);
            }

            int runningSum = 0;

            for (int i = 0; i < s.Length - 1; i++)
            {
                runningSum += (s[i] - 'a' + 1);

                if (runningSum * 2 == totalScore)
                    return true;
            }

            return false;
        }
}