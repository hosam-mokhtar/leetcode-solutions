Link: https://leetcode.com/problems/reverse-string-prefix/
Language: C#





public class Solution {
        public string ReversePrefix(string s, int k)
        {
            var res = new char[s.Length];

            for (int i = 0; i < s.Length; i++)
            {
                if (i < k)
                    res[k - i - 1] = s[i];
                else
                    res[i] = s[i];
            }

            return new string(res);
        }
}