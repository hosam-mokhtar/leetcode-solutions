Link: https://leetcode.com/problems/check-divisibility-by-digit-sum-and-product/
Language: C#








public class Solution {
        public bool CheckDivisibility(int n)
        {
            int sum = 0, product = 1, temp = n;

            while (n > 0)
            {
                int i = n % 10;
                sum += i;
                product *= i;
                n /= 10;
            }

            return temp % (sum + product) == 0;
        }
}