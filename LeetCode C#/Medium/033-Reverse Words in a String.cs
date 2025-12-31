Link: https://leetcode.com/problems/reverse-words-in-a-string/
Language: C#







public class Solution {
        public string ReverseWords(string s)
        {
            var words = s.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            StringBuilder sb = new StringBuilder();

            for (int i = words.Length - 1; i > 0; i--)
            {
                sb.Append(words[i]);
                sb.Append(' ');
            }
            sb.Append(words[0]);

            return sb.ToString();
        }
}