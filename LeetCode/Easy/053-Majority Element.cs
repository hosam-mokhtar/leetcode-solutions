Link: https://leetcode.com/problems/majority-element/
Language: C#



public class Solution {
public int MajorityElement(int[] nums)
        {
            int c1 = 0, c2 = 0;
            int m = nums.Length  2;
            for(int i = 0; i  nums.Length; i++)
            {
                if (nums[i] == c1)
                    c2++;
                else
                    c2--;
                if (c2m)
                    return c1;
            }
            return 0;
        }
}