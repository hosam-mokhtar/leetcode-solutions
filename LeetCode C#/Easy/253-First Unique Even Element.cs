Link: https://leetcode.com/problems/first-unique-even-element/
Language: C#








public class Solution {
        public int FirstUniqueEven(int[] nums)
        {
            int[] freq = new int[101];

            for (int i = 0; i < nums.Length; i++)
            {
                freq[nums[i]]++;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if ((nums[i] & 1) == 0 && freq[nums[i]] == 1)
                    return nums[i];
            }

            return -1;
        }
}