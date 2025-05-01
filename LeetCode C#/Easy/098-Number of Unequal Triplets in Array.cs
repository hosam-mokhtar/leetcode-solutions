Link: https://leetcode.com/problems/number-of-unequal-triplets-in-array/
Language: C#





public class Solution {
        public int UnequalTriplets(int[] nums)
        {
            int counter = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] != nums[j])
                    for (int k = j + 1; k < nums.Length; k++)
                    {
                        if(nums[i] != nums[k] && nums[j] != nums[k])
                            counter++;

                    }
                }
            }
            return counter;
        }
}