Link: https://leetcode.com/problems/sum-of-values-at-indices-with-k-set-bits/
Language: C#



public class Solution {
        public int SumIndicesWithKSetBits(IList<int> nums, int k)
        {   int sum = 0;
            for (int i = 0; i < nums.Count; i++) {
                if (int.PopCount(i) == k)
                    sum += nums[i];          
            }
            return sum;
        }
}