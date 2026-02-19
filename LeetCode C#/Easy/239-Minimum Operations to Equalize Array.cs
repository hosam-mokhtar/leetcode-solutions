Link: https://leetcode.com/problems/minimum-operations-to-equalize-array/
Language: C#






public class Solution {
        public int MinOperations(int[] nums)
        {
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[0])
                    return 1;
            }

            return 0;
        }
}