Link: https://leetcode.com/problems/most-frequent-number-following-key-in-an-array/
Language: C#








public class Solution {
        public int MostFrequent(int[] nums, int key)
        {
            Span<int> freq = stackalloc int[1001];
            int max = 0;
            int res = 0;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (key == nums[i])
                {
                    int n = ++freq[nums[i + 1]];

                    if (n > max)
                    {
                        res = nums[i + 1];
                        max = n;
                    }
                }
            }

            return res;
        }
}