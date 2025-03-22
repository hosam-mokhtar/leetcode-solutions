Link: https://leetcode.com/problems/rotate-array/
Language: C#





public class Solution {
        public void Rotate(int[] nums, int k)
        {
            if (k > nums.Length)
                k %= nums.Length;
            if (k > 0 && k < nums.Length)
            {
                Array.Reverse(nums);
                Array.Reverse(nums, 0, k);
                Array.Reverse(nums, k, nums.Length - k);
            }
        }
}