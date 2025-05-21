Link: https://leetcode.com/problems/third-maximum-number/
Language: C#







public class Solution {
        public int ThirdMax(int[] nums)
        {
            long max1 = long.MinValue;
            long max2 = long.MinValue;
            long max3 = long.MinValue;
            
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == max1 || nums[i] == max2 || nums[i] == max3) continue;
                
                if (max1 < nums[i])
                {
                    max3 = max2;
                    max2 = max1;
                    max1 = nums[i];
                }
                else if (max2 < nums[i])
                {
                    max3 = max2;
                    max2 = nums[i];
                }
                else if (max3 < nums[i])
                {
                    max3 = nums[i];
                }
            }

            return max3 == long.MinValue ? (int)max1 : (int)max3;
        }
}