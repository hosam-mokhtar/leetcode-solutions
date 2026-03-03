Link: https://leetcode.com/problems/trim-trailing-vowels/
Language: C#







public class Solution {
        public string TrimTrailingVowels(string s)
        {
            string vowels = "aeiou";

            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (!vowels.Contains(s[i]))
                    return s.Substring(0, i + 1);
            }

            return "";
        }
}