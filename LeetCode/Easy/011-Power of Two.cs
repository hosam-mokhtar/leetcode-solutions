Link: https://leetcode.com/problems/power-of-two/description/
Language: C#



public class Solution {
   public bool IsPowerOfTwo(int n)
        {
            if (n <= 0)
            {
                return false;
            }
            while (n % 2 == 0)
            {
                n = n / 2;
            }
            return n==1;
        }
}