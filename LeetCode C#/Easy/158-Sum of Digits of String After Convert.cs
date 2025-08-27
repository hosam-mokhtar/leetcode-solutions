Link: https://leetcode.com/problems/sum-of-digits-of-string-after-convert/
Language: C#






public class Solution {
        public int GetLucky(string s, int k)
        {
            int sum = 0;

            for (int i = 0; i < s.Length; i++)
            {
                sum += Sum(s[i] - 'a' + 1);
            }

            while (k > 1)
            {
                sum = Sum(sum);
                k--;
            }

            return sum;
        }

        public int Sum(int n)
        {
            int sum = 0;

            while (n > 0)
            {
                int digit = n % 10;
                n /= 10;
                sum += digit;
            }

            return sum;
        }
}