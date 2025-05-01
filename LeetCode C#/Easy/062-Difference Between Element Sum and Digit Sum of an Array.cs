Link: https://leetcode.com/problems/difference-between-element-sum-and-digit-sum-of-an-array/
Language: C#



public class Solution {
        public int DifferenceOfSum(int[] nums)
        {
            int element_sum = 0;
            int digit_sum = 0;
            foreach (int i in nums)
            {   element_sum += i;
                int digit = i;
                while (digit > 0)
                {
                    digit_sum += digit % 10;
                    digit /= 10;
                }
            }
            return Math.Abs(element_sum - digit_sum);
        }
}