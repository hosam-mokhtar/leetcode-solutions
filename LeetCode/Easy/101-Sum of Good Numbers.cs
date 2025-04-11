Link: https://leetcode.com/problems/sum-of-good-numbers/
Language: C#





public class Solution {
        public int SumOfGoodNumbers(int[] nums, int k)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i - k >= 0 && i + k < nums.Length)
                {
                    if (nums[i] > nums[i - k] && nums[i] > nums[i + k])
                        sum += nums[i];
                }
                else if(i - k >= 0)
                {
                    if (nums[i] > nums[i - k])
                        sum += nums[i];

                }
                else if(i + k < nums.Length)
                {
                    if (nums[i] > nums[i + k])
                        sum += nums[i];
                }
            }
            return sum;
        }
}