Link: https://leetcode.com/problems/sum-multiples/
Language: C#


public class Solution {
public int SumOfMultiples(int n) {
        int res = 0;
            for (int i = 3; i <= n; i++)
            {
                if( i%3==0 || i%5==0 || i%7==0 ) res += i;
            }
        return res;
        }
}