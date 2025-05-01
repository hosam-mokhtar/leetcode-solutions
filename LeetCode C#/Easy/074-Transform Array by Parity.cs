Link: https://leetcode.com/problems/transform-array-by-parity/
Language: C#




public class Solution {
        public int[] TransformArray(int[] nums)
        {  
            int l = 0;
            int r = nums.Length-1;
            int[]ans = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {   if (nums[i] % 2 == 0)
                {
                    ans[l] = 0;
                    l++;
                }
                else
                {
                    ans[r] = 1;
                    r--;
                }
            }
            return ans;
        }
}