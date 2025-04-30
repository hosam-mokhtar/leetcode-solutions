Link: https://leetcode.com/problems/remove-duplicates-from-sorted-array-ii/
Language: C#






public class Solution {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length < 3) return nums.Length;
            int index = 2;
            for (int i = 2; i < nums.Length; i++)
            {
                if (nums[i] != nums[index - 2])
                {
                    nums[index] = nums[i];
                    index++;
                }
            }
            return index;
        }
}