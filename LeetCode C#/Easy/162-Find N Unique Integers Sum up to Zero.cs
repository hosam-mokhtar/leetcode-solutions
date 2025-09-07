Link: https://leetcode.com/problems/find-n-unique-integers-sum-up-to-zero/
Language: C#







public class Solution {
        public int[] SumZero(int n)
        {
            int[] nums = new int[n];
            int index = 0;

            if (n % 2 != 0)
            {
                nums[0] = 0;
                index++;
            }

            for (int i = 1; i < nums.Length; i += 2)
            {
                nums[index] = i;
                index++;
                nums[index] = i * -1;
                index++;
            }

            return nums;
        }
}