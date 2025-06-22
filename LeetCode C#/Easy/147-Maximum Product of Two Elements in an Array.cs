Link: https://leetcode.com/problems/maximum-product-of-two-elements-in-an-array/
Language: C#







public class Solution {
        public int MaxProduct(int[] nums)
        {
            int firstMaxElement = int.MinValue;
            int secondMaxElement = int.MinValue;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > firstMaxElement)
                {
                    secondMaxElement = firstMaxElement;
                    firstMaxElement = nums[i];
                    
                }
                else if (nums[i] > secondMaxElement)
                {
                    secondMaxElement = nums[i];
                }
            }

            return (secondMaxElement - 1) * (firstMaxElement - 1);
        }
}