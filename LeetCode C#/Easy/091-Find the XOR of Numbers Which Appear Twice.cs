Link: https://leetcode.com/problems/find-the-xor-of-numbers-which-appear-twice/
Language: C#






public class Solution {
        public int DuplicateNumbersXOR(int[] nums)
        {
            int[]freq= new int[51];
            int xorNums = 0;
            for (int i = 0; i < nums.Length; i++) {
                freq[nums[i]]++;
            }
            for (int i = 0; i < freq.Length; i++)
            { 
                if(freq[i] == 2) 
                   xorNums ^= i;
            }
            return xorNums;
        }
}