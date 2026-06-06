Link: https://leetcode.com/problems/left-and-right-sum-differences/
Language: C#









public class Solution {
        public int[] LeftRightDifference(int[] nums)
        {
            int[] result = new int[nums.Length];
            int leftSum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = leftSum;
                leftSum += nums[i];
            }

            int rightSum = 0;

            for (int i = nums.Length - 1; i >= 0; i--)
            {
                result[i] = Math.Abs(result[i] - rightSum);
                rightSum += nums[i];
            }

            return result;
        }
}