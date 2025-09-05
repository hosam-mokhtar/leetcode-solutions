Link: https://leetcode.com/problems/missing-number/
Language: C#







public class Solution {
        public int MissingNumber(int[] nums)
        {
            int totalSum = (nums.Length + 1) * (nums.Length) / 2;
            int sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }

            return totalSum - sum;
        }
}