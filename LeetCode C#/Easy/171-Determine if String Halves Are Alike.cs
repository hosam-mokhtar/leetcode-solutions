Link: https://leetcode.com/problems/determine-if-string-halves-are-alike/
Language: C#







public class Solution {
        public bool HalvesAreAlike(string s)
        {
            string vowels = "aeiouAEIOU";
            string a = s.Substring(0, s.Length / 2);
            string b = s.Substring(s.Length / 2, s.Length / 2);
            int c1 = 0, c2 = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (vowels.Contains(a[i]))
                    c1++;
            }

            for (int i = 0; i < b.Length; i++)
            {
                if (vowels.Contains(b[i]))
                    c2++;
            }

            return c1 == c2;
        }
}