Link: https://leetcode.com/problems/minimum-operations-to-exceed-threshold-value-i/
Language: C#







public class Solution {
        public int MinOperations(int[] nums, int k)
        {
            int counter = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < k)
                    counter++;
            }
            return counter;
        }
}