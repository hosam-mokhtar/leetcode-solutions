Link: https://leetcode.com/problems/final-array-state-after-k-multiplication-operations-i/
Language: C#





public class Solution {
        public int[] GetFinalState(int[] nums, int k, int multiplier)
        {   if(multiplier==1) return nums;
            for (int i = 0; i < k; i++) 
            {
                int index = 0;
                int minvalue = int.MaxValue;
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[j] < minvalue)
                    {
                        minvalue = nums[j];
                        index = j;
                    }
                }
                nums[index] = minvalue * multiplier;
            }
            return nums;
        }
}