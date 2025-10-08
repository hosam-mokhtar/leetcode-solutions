Link: https://leetcode.com/problems/compute-alternating-sum/
Language: C#







public class Solution {
        public int AlternatingSum(int[] nums)
        {
            int sum = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                if (i % 2 == 0)
                    sum += nums[i];
                else
                    sum -= nums[i];
            }
            
            return sum;
        }
}