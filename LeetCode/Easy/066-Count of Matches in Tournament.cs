Link: https://leetcode.com/problems/count-of-matches-in-tournament/
Language: C#




public class Solution {
        public int NumberOfMatches(int n)
        {
            int sum = 0;
            while (n > 1)
            {
                if (n % 2 == 0)
                {
                    sum += (n / 2);
                    n -= (n / 2);
                }
                else
                {
                    sum += ((n - 1) / 2);
                    n-= ((n - 1) / 2);
                }
            }
            return sum;
        }
}