Link: https://leetcode.com/problems/maximum-difference-between-adjacent-elements-in-a-circular-array/
Language: C#






public class Solution {
        public int MaxAdjacentDistance(int[] nums)
        {
            int max = 0;
            
            max = Math.Abs(nums[nums.Length - 1] - nums[0]);

            for (int i = 0; i < nums.Length - 1; i++)
            {
                max = Math.Max(max, Math.Abs(nums[i + 1] - nums[i]));
            }

            return max;
        }
}