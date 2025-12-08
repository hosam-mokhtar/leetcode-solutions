Link: https://leetcode.com/problems/split-the-array/
Language: C#






public class Solution {
        public bool IsPossibleToSplit(int[] nums)
        {
            int[] freq = new int[101];

            for (int i = 0; i < nums.Length; i++)
            {
                if (++freq[nums[i]] > 2)
                    return false;
            }

            return true;
        }
}