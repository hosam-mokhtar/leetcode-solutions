Link: https://leetcode.com/problems/sort-array-by-parity/
Language: C#







public class Solution {
        public int[] SortArrayByParity(int[] nums)
        {
            int[] result = new int[nums.Length];
            int evenNumbers = 0;
            int oddNumbers = result.Length - 1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    result[evenNumbers] = nums[i];
                    evenNumbers++;
                }
                else
                {
                    result[oddNumbers] = nums[i];
                    oddNumbers--;
                }
            }
            return result;
        }
}