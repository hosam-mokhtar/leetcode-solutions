Link: https://leetcode.com/problems/number-of-zero-filled-subarrays/
Language: C#







public class Solution {
        public long ZeroFilledSubarray(int[] nums)
        {
            long totalCounter = 0;
            long counter = 0;

            for (int i = 0; i < nums.Length + 1; i++)
            {
                if (i < nums.Length && nums[i] == 0)
                    counter++;
                else
                {
                    if (counter == 1)
                        totalCounter += 1;
                    else
                        totalCounter += (counter + 1) * counter / 2;

                    counter = 0;
                }
            }

            return totalCounter;
        }
}