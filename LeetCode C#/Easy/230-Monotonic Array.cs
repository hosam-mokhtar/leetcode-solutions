Link: https://leetcode.com/problems/monotonic-array/
Language: C#







public class Solution {
        public bool IsMonotonic(int[] nums)
        {
            bool flag1 = true;
            bool flag2 = true;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i - 1] == nums[i])
                    continue;
                else if (nums[i - 1] < nums[i] && flag1)
                    flag2 = false;
                else if (nums[i - 1] > nums[i] && flag2)
                    flag1 = false;
                else
                    return false;
            }

            return true;
        }
}