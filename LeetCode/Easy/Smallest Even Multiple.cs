Link: https://leetcode.com/problems/smallest-even-multiple/
Language: C#




public class Solution {
public int SmallestEvenMultiple(int n)
        {
            int x = n / 2;
            if (x==n/2f)
               return n;
            else 
                return 2*n;
        }
}