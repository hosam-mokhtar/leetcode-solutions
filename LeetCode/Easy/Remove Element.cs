Link: https://leetcode.com/problems/remove-element/
Language: C#



public class Solution {
    public int RemoveElement(int[] nums, int val)
        {
            int counter=nums.Length;
            int j = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[j] = nums[i];
                    j++;
                }
                else
                {
                    counter--;
                }  
               
            }
            return counter;
        }
}