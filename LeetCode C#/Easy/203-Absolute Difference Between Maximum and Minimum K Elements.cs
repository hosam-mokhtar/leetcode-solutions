Link: https://leetcode.com/problems/absolute-difference-between-maximum-and-minimum-k-elements/
Language: C#






public class Solution {
        public int AbsDifference(int[] nums, int k)
        {
            Array.Sort(nums);
            int sum = 0;

            for (int i = 0; i < k; i++)
            {
                sum -= nums[i];
                sum += nums[nums.Length - 1 - i];
            }

            return sum;
        }
}