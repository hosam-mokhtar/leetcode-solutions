Link: https://leetcode.com/problems/find-the-score-of-all-prefixes-of-an-array/
Language: C#





public class Solution {
        public long[] FindPrefixScore(int[] nums)
        {
            long[] ans = new long[nums.Length];
            long sum = 0;
            int max = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                max= Math.Max(max, nums[i]);
                sum += nums[i] + max;
                ans[i] = sum;
            }
            return ans;
        }
}