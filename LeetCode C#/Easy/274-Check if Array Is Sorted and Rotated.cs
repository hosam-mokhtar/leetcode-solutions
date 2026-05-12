Link: https://leetcode.com/problems/check-if-array-is-sorted-and-rotated/
Language: C#







public class Solution {
        public bool Check(int[] nums)
        {
            if (nums.Length == 1) return true;
            
            int[] temp = new int[nums.Length * 2];
            int index = 0;

            for (int i = 0; i < temp.Length; i++)
            {
                if (index == nums.Length)
                    index = 0;
                temp[i] = nums[index];
                index++;
            }

            int c = 1;
            int maxLen = 1;

            for (int i = 1; i < temp.Length; i++)
            {
                if (temp[i - 1] <= temp[i])
                    c++;
                else
                {
                    maxLen = Math.Max(maxLen, c);
                    c = 1;
                }

                maxLen = Math.Max(maxLen, c);
                if (maxLen == nums.Length)
                    return true;
            }

            return false;
        }
}