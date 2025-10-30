Link: https://leetcode.com/problems/neither-minimum-nor-maximum/
Language: C#






public class Solution {
        public int FindNonMinOrMax(int[] nums)
        {
            if (nums.Length > 2)
            {
                if (nums[0] < nums[1])
                {
                    if (nums[0] > nums[2])
                        return nums[0];
                }
                else if (nums[0] < nums[2])
                    return nums[0];

                if (nums[1] < nums[0])
                {
                    if (nums[1] > nums[2])
                        return nums[1];
                }
                else if (nums[1] < nums[2])
                    return nums[1];

                if (nums[2] < nums[0])
                {
                    if (nums[2] > nums[1])
                        return nums[2];
                }
                else if (nums[2] < nums[1])
                    return nums[2];
            }

            return -1;
        }
}