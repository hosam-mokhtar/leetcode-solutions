Link: https://leetcode.com/problems/find-the-duplicate-number/
Language: C#






public class Solution {
        public int FindDuplicate(int[] nums)
        {
            bool[] freq = new bool[nums.Length + 1];

            for (int i = 0; i < nums.Length; i++) 
            {
                if (freq[nums[i]] is false)
                    freq[nums[i]] = true;
                else
                    return nums[i];
            }

            return -1;
        }
}