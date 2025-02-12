Link: https://leetcode.com/problems/divide-two-integers/
Language: C#




public class Solution {
public int Divide(int dividend, int divisor)
{
    if (dividend == 0)
        return 0;
   else if (dividend ==int.MinValue && divisor ==-1)
        return  int.MaxValue;
    return dividend / divisor;
}
}