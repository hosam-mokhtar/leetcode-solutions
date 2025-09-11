Link: https://leetcode.com/problems/smallest-index-with-digit-sum-equal-to-index/
Language: C#






public class Solution {
        public int SmallestIndex(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] >= 0)
                {
                    int sum = 0;
                    while (nums[i] > 0)
                    {
                        int index = nums[i] % 10;
                        sum += index;
                        nums[i] /= 10;
                    }
                    if (sum == i)
                        return i;
                }
            }

            return -1;
        }
}