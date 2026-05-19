Link: https://leetcode.com/problems/sum-of-variable-length-subarrays/
Language: C#






public class Solution {
        public int SubarraySum(int[] nums)
        {
            int[] temp = new int[nums.Length];
            temp[0] = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                temp[i] = temp[i - 1] + nums[i];
            }

            int sum = temp[0];

            for (int i = 1; i < nums.Length; i++)
            {
                int start = Math.Max(0, i - nums[i]);

                if (start == 0)
                    sum += temp[i];
                else
                    sum += temp[i] - temp[start - 1];
            }

            return sum;
        }
}