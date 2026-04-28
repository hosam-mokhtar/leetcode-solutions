Link: https://leetcode.com/problems/valid-digit-number/
Language: C#








public class Solution {
    public bool ValidDigit(int n, int x) 
    {
        bool xSeen = false;
        int digit = 0;

        while (n != 0) 
        {
            digit = n % 10;
            n /= 10;
            if (digit == x)
                xSeen = true;
        }

        return xSeen && digit != x;
    }
}