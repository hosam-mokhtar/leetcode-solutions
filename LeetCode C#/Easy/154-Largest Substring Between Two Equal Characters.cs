Link: https://leetcode.com/problems/largest-substring-between-two-equal-characters/
Language: C#






public class Solution {
        public int MaxLengthBetweenEqualCharacters(string s)
        {
            int max = -1;

            for (int i = 0; i < s.Length; i++)
            {
                max = Math.Max(max, s.LastIndexOf(s[i]) - s.IndexOf(s[i]) - 1);
            }

            return max;
        }
}