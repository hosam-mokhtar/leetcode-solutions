Link: https://leetcode.com/problems/richest-customer-wealth/
Language: C#


public class Solution {
public int MaximumWealth(int[][] accounts) {
            int wealth = 0;
            int sum = 0;
            for (int i = 0; i < accounts.Length; i++) { 
            for (int j = 0; j < accounts[i].Length; j++) { 
                sum+=accounts[i][j];
                }
                if (wealth < sum)
                    wealth = sum;
                sum = 0;
            }
            return wealth;
        }
}