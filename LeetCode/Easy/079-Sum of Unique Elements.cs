Link: https://leetcode.com/problems/sum-of-unique-elements/
Language: C#




public class Solution {
        public int SumOfUnique(int[] nums)
        {
            int sum = 0;
            int[]n= new int[101];
            for (int i = 0; i < nums.Length; i++)
            {
                n[nums[i]]++;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (n[nums[i]] == 1)
                sum += nums[i];
            }
            return sum;
        }
}