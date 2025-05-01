Link: https://leetcode.com/problems/strictly-palindromic-number/
Language: C#





public class Solution {
        public bool IsStrictlyPalindromic(int n)
        {
            for (int i = 2; i <= n; i++)
            {   int temp = n;
                StringBuilder sb = new StringBuilder();
                while (temp > 0)
                {
                    sb.Append(temp % i);
                    temp /= i;
                }
                for (int j = 0; j < sb.Length; j++)
                {
                    if (sb[j] != sb[sb.Length - 1 - j])
                        return false;
                }
            }
            return true;
            // note: Based on mathematical proof, no number is strictly palindromic.
            // return false;      
        }
}