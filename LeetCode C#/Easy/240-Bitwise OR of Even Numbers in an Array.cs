Link: https://leetcode.com/problems/bitwise-or-of-even-numbers-in-an-array/
Language: C#







public class Solution {
        public int EvenNumberBitwiseORs(int[] nums)
        {
            int n = 0;

            foreach (var num in nums)
            {
                if ((num & 1) == 0)
                    n |= num;
            }

            return n;
        }
}