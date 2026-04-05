Link: https://leetcode.com/problems/number-of-substrings-with-only-1s/
Language: C#








public class Solution {
        public int NumSub(string s)
        {
            long res = 0;
            long c = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '1')
                {
                    c++;
                    res += c;
                }
                else
                    c = 0;
            }
            return (int)(res % 1000000007);
        }
}