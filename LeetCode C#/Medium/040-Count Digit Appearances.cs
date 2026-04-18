Link: https://leetcode.com/problems/count-digit-appearances/
Language: C#








public class Solution {
        public int CountDigitOccurrences(int[] nums, int digit)
        {
            int c = 0;

            foreach (var i in nums)
            {
                for (var temp = i; temp > 0; temp /= 10)
                    c += (temp % 10 == digit) ? 1 : 0;
            }

            return c;
        }
}