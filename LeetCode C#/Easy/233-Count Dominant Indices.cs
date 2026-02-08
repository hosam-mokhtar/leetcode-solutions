Link: https://leetcode.com/problems/count-dominant-indices/
Language: C#








public class Solution {
        public int DominantIndices(int[] nums)
        {
            if (nums.Length == 1) return 0;

            int c = 0;
            int sum = nums[^1];

            for (int i = nums.Length - 2; i >= 0; i--)
            {
                if (nums[i] > sum / (nums.Length - 1 - i))
                    c++;

                sum += nums[i];
            }

            return c;
        }
}