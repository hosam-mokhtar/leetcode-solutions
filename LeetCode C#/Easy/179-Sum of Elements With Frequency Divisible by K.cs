Link: https://leetcode.com/problems/sum-of-elements-with-frequency-divisible-by-k/
Language: C#








public class Solution {
        public int SumDivisibleByK(int[] nums, int k)
        {
            int[] freq = new int[101];

            for (int i = 0; i < nums.Length; i++)
            {
                freq[nums[i]]++;
            }

            int sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (freq[nums[i]] % k == 0)
                    sum += nums[i];
            }

            return sum;
        }
}