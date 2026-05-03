Link: https://leetcode.com/problems/sum-of-primes-between-number-and-its-reverse/
Language: C#







public class Solution {
        public int ReverseNumber(int n)
        {
            int reversed = 0;

            while (n > 0)
            {
                reversed = (reversed * 10) + (n % 10);
                n /= 10;
            }
            
            return reversed;
        }
        public int SumOfPrimesInRange(int n)
        {
            int reversed = ReverseNumber(n);

            int min = Math.Min(reversed, n);
            int max = Math.Max(reversed, n);
            int SumOfPrimes = 0;

            for (int i = min; i <= max; i++)
            {
                if (i < 2) continue;

                bool isPrime = true;
                double sqrt = Math.Sqrt(i);

                for (int j = 2; j <= sqrt; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                    SumOfPrimes += i;
            }

            return SumOfPrimes;
        }
}