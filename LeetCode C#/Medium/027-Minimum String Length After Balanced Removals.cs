Link: https://leetcode.com/problems/minimum-string-length-after-balanced-removals/
Language: C#








public class Solution {
        public int MinLengthAfterRemovals(string s)
        {
            int c = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'a')
                    c++;
            }

            return Math.Abs(s.Length - c - c);
        }
}