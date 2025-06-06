Link: https://leetcode.com/problems/calculate-amount-paid-in-taxes/
Language: C#







public class Solution {
        public double CalculateTax(int[][] brackets, int income)
        {
            int prev = Math.Min(brackets[0][0], income);
            double tax = prev * brackets[0][1];

            for (int i = 1; i < brackets.Length; i++)
            {
                int x = Math.Min(brackets[i][0], income);
                int sub = x - prev;
                prev = x;
                tax += (sub * brackets[i][1]);
            }

            return tax / 100;
        }
}