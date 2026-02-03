Link: https://leetcode.com/problems/trionic-array-i/
Language: C#








public class Solution {
        public bool IsTrionic(int[] nums)
        {
            bool flag1 = false, flag2 = false, flag3 = false;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] < nums[i + 1] && !flag2)
                    flag1 = true;
                else if (nums[i] > nums[i + 1] && !flag3)
                    flag2 = true;
                else if (nums[i] < nums[i + 1])
                    flag3 = true;
                else
                    return false;
            }

            return flag1 && flag2 && flag3;
        }
}