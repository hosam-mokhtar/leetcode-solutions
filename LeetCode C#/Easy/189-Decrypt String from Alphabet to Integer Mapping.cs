Link: https://leetcode.com/problems/decrypt-string-from-alphabet-to-integer-mapping/
Language: C#








public class Solution {
        public string FreqAlphabets(string s)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < s.Length; i++)
            {
                if (i + 2 < s.Length && s[i + 2] == '#')
                {
                    sb.Append((char)(((s[i] - '0') * 10 + (s[i + 1] - '0')) + 'a' - 1));
                    i += 2;
                }
                else
                    sb.Append((char)((s[i] - '0') + 'a' - 1));
            }

            return sb.ToString();
        }
}