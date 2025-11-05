Link: https://leetcode.com/problems/replace-all-digits-with-characters/
Language: C#







public class Solution {
        public string ReplaceDigits(string s)
        {
            StringBuilder sb = new();
            sb.Append(s[0]);

            for (int i = 1; i < s.Length; i++)
            {
                if (char.IsDigit(s[i]))
                    sb.Append((char)(s[i - 1] + (s[i] - '0')));
                else
                    sb.Append(s[i]);
            }

            return sb.ToString();
        }
}