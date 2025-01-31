Link: https://leetcode.com/problems/perfect-number/
Language: C#


public class Solution {
public bool CheckPerfectNumber(int num)
        {
            int sum = 0;
            for (int i = 1; i <= num / 2; i++)
            {
                if (num%i==0)
                {
                    sum += i;
                }
            }
            return sum == num;
        }
}