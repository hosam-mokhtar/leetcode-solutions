Link: https://leetcode.com/problems/divisible-and-non-divisible-sums-difference/
Language: C#






public class Solution {
        public int DifferenceOfSums(int n, int m)
        {
            int sum = n * (n + 1) / 2;

            if (m == 1) return -sum;

            for (int i = 0; i <= n; i += m)
            {
                sum -= 2 * i;
            }

            return sum;
        }
}