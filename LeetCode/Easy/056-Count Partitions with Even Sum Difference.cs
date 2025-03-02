Link: https://leetcode.com/problems/count-partitions-with-even-sum-difference/
Language: C#




public class Solution {
        public int CountPartitions(int[] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            if (sum%2== 0)
                return nums.Length - 1;
            return 0;
        }
}