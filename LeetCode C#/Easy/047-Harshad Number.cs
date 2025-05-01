Link: https://leetcode.com/problems/harshad-number/
Language: C#


public class Solution {
public int SumOfTheDigitsOfHarshadNumber(int x) {
            int res = 0;
            int n = x;
            while (x > 0)
            {
                res += x % 10;
                x /= 10;
            }
            return n % res == 0 ? res : -1;
        }
}