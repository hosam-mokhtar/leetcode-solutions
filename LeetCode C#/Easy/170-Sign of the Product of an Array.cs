Link: https://leetcode.com/problems/sign-of-the-product-of-an-array/
Language: C#






public class Solution {
        public int ArraySign(int[] nums)
        {
            int p = 1;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                    p *= 1;
                else if (nums[i] < 0)
                    p *= -1;
                else
                {
                    p = 0;
                    break;
                }
            }

            return p;
        }
}