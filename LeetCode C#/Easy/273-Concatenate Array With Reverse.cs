Link: https://leetcode.com/problems/concatenate-array-with-reverse/
Language: C#







public class Solution {
        public int[] ConcatWithReverse(int[] nums)
        {
            int len = nums.Length * 2;
            int[] result = new int[len];

            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = nums[i];
                result[len - 1 - i] = nums[i];
            }

            return result;
        }
}