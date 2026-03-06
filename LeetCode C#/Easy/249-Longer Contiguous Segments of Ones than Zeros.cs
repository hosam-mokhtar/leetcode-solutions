Link: https://leetcode.com/problems/longer-contiguous-segments-of-ones-than-zeros/
Language: C#







public class Solution {
        public bool CheckZeroOnes(string s)
        {
            int c1 = 0, c2 = 0;
            int max1 = 0, max2 = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '0')
                {
                    c2++;
                    max2 = Math.Max(c2, max2);
                    c1 = 0;
                    if (c1 > s.Length)
                        return true;
                }
                else
                {
                    c1++;
                    max1 = Math.Max(c1, max1);
                    c2 = 0;
                }
            }

            return max1 > max2;
        }
}