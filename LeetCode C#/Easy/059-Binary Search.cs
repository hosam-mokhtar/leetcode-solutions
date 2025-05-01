Link: https://leetcode.com/problems/binary-search/
Language: C#




public class Solution {
        public int Search(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length-1;
            int m = (right + left) / 2;
            while(left<=right){
                if (nums[m] == target)
                {
                    return m;
                }
                else if (nums[m] < target) { 
                   left = m+1;
                }
                else{
                 right = m-1;              
                }
                m = (right + left) / 2;     
            }
            return -1;
        }
}