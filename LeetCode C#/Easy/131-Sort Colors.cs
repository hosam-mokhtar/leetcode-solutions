Link: https://leetcode.com/problems/sort-colors/
Language: C#






public class Solution {
       public void SortColors(int[] nums)
       {
           int[] result = new int[nums.Length];
           int left = 0;
           int right = nums.Length - 1;

           for (int i = 0; i < nums.Length; i++)
           {
               if (nums[i] == 0)
                   result[left++] = 0;
               else if (nums[i] == 2)
                   result[right--] = 2;
           }

           for (int i = nums.Length - 1; i >= 0; i--)
           {
               if (result[i] != 2 && left <= right)
                   result[right--] = 1;

               nums[i] = result[i];
           }

       }
}