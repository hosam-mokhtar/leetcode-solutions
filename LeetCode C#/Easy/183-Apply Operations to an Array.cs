Link: https://leetcode.com/problems/apply-operations-to-an-array/
Language: C#







public class Solution {
        public int[] ApplyOperations(int[] nums)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    nums[i] *= 2;
                    nums[i + 1] = 0;
                }
            }

            int index = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                    nums[index++] = nums[i];
            }

            for (int i = index; i < nums.Length; i++)
            {
                nums[index] = 0;
                index++;
            }

            return nums;
        }
}