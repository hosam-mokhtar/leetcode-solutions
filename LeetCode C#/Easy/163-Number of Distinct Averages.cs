Link: https://leetcode.com/problems/number-of-distinct-averages/
Language: C#






public class Solution {
        public int DistinctAverages(int[] nums)
        {
            Array.Sort(nums);

            bool[] freq = new bool[201];
            int counter = 0;

            for (int i = 0; i < nums.Length / 2; i++)
            {
                if (!freq[nums[i] + nums[nums.Length - 1 - i]])
                {
                    freq[nums[i] + nums[nums.Length - 1 - i]] = true;
                    counter++;
                }
            }
            
            return counter;
        }
}