Link: https://leetcode.com/problems/find-the-highest-altitude/
Language: C#




public class Solution {
        public int LargestAltitude(int[] gain)
        {   int max = 0;
            int[]temp = new int[gain.Length+1];
            for (int i = 1; i <= gain.Length; i++)
            {
                temp[i] = gain[i - 1] + temp[i-1];
                if(temp[i] > max)
                    max = temp[i];
            }
            return max;
        }
}