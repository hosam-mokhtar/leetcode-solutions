Link: https://leetcode.com/problems/maximum-difference-between-increasing-elements/
Language: C#






public class Solution {
        public int MaximumDifference(int[] nums)
        {
            int max = -1;
            int prefix = nums[0];

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > prefix)
                {
                    max = Math.Max(max, nums[i] - prefix);
                }
                else
                {
                    prefix = nums[i];
                }
            }

            return max;
        }
}