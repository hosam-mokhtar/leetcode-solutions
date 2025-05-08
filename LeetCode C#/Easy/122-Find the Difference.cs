Link: https://leetcode.com/problems/find-the-difference/
Language: C#





public class Solution {
        public char FindTheDifference(string s, string t)
        {
            int result = 0;

            for (int i = 0; i < s.Length; i++)
                result ^= s[i];
            for (int i = 0; i < t.Length; i++)
                result ^= t[i];
            return (char)result;
        }
}