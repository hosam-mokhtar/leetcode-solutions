Link: https://leetcode.com/problems/valid-perfect-square/
Language: C#



public class Solution {
public bool IsPerfectSquare(int num)
        {
             int sqrt =(int)Math.Sqrt(num);
             return (long)sqrt*sqrt==num?true:false;
       /*   for (int i = 1; (long) i*i <= num; i++)
                {
                    if (i * i == num)
                        return true;
                }         
            return false;
      */
        }
}