Link: https://leetcode.com/problems/find-the-k-beauty-of-a-number/
Language: C#





public class Solution {
        public int DivisorSubstrings(int num, int k)
        {
            int counter = 0;
            string s = num.ToString();
            for (int i = 0; i <= s.Length - k; i++)
            {
                StringBuilder sb = new StringBuilder();
                for (int j = i; j < k + i; j++)
                {
                    sb.Append((s[j] - '0'));
                }
                int x = int.Parse(sb.ToString());
                if (x != 0 && num % x == 0)
                    counter++;
            }
            return counter;
        }
}