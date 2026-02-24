Link: https://leetcode.com/problems/reverse-bits/
Language: C#








public class Solution {
        public int ReverseBits(int n)
        {
            int res = 0;

            for (int i = 0; i < 32; i++)
            {
                res <<= 1;        // Make room 
                res |= (n & 1);
                n >>= 1;
            }

            return res;
        }
}