Link: https://leetcode.com/problems/sum-of-digits-of-string-after-convert/
Language: C#






public class Solution {
        public int GetLucky(string s, int k)
        {
            int sum = 0;
            string temp = "";

            for (int i = 0; i < s.Length; i++)
            {
                temp += s[i] - 'a' + 1;
            }

            while (k >= 1)
            {
                sum = 0;

                for (int i = 0; i < temp.Length; i++)
                {
                    sum += temp[i] - '0';
                }

                temp = sum.ToString();
                k--;
            }

            return sum;
        }
}