Link: https://leetcode.com/problems/minimum-operations-to-make-array-sum-divisible-by-k/
Language: C#






public class Solution {
        public int MinOperations(int[] nums, int k)
        {
          return nums.Sum() % k;
        }
}