Link: https://leetcode.com/problems/average-value-of-even-numbers-that-are-divisible-by-three/
Language: C#



public class Solution {
public int AverageValue(int[] nums)
        {
            int counter = 0;
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                // Since 6 is Minimun number (6%2==0) & (6%3==0) 12,18,24......etc
                // Then (num%6==0)
                if (nums[i] % 6 == 0 )
                   {
                        sum += nums[i];
                        counter++;                   
                   }
            }
                return sum >0?sum/counter:0;
        }
}