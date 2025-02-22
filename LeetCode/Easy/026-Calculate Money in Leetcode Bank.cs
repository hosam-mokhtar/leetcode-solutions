Link: https://leetcode.com/problems/calculate-money-in-leetcode-bank/
Language: C#



public class Solution {
public int TotalMoney(int n)
        {
            int profit = 0;
            int sum = 0;
            int counter = 1;
            for (int i = 1;i <= n;i++)
            {
                sum += counter + profit;
                counter++;
                if (i % 7 == 0)
                {   profit++;
                    counter = 1; 
                }              
            }
          return sum >= 1 ? sum : n;
        }
}