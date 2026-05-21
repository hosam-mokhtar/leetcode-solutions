Link: https://leetcode.com/problems/check-adjacent-digit-differences/
Language: C#







public class Solution {
        public bool IsAdjacentDiffAtMostTwo(string s)
        {
            for (int i = 1; i < s.Length; i++)
            {
                if (Math.Abs(s[i - 1] - s[i]) > 2)
                    return false;
            }

            return true;
        }
}