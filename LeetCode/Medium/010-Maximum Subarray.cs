Link: https://leetcode.com/problems/maximum-subarray/
Language: C#





public class Solution {
        public int MaxSubArray(int[] nums)
        {
            int maxsum = int.MinValue;
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
               sum = Math.Max(nums[i],nums[i]+sum);
               maxsum =Math.Max(maxsum,sum);
            }
            return maxsum;
        }
}