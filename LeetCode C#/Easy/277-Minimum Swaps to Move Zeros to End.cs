Link: https://leetcode.com/problems/minimum-swaps-to-move-zeros-to-end/
Language: C#








public class Solution {
        public int MinimumSwaps(int[] nums)
        {
            int right = nums.Length - 1;
            int swaps = 0;

            for (int left = 0; left < nums.Length; left++)
            {
                if (nums[left] == 0)
                {
                    while (nums[right] == 0 && left < right)
                    {
                        right--;
                    }
                    if (left < right)
                    {
                        right--;
                        swaps++;
                    }
                    else
                        break;
                }
            }

            return swaps;
        }
}