Link: https://leetcode.com/problems/majority-element/
Language: C#



public class Solution {
        public int MajorityElement(int[] nums)
        {
            int element = 0, counter = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (counter == 0)
                {
                    counter++;
                    element = nums[i];
                }
                else if (nums[i] == element)
                    counter++;
                else
                    counter--;
            }

            return element;
        }
}