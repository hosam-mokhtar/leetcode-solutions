Link: https://leetcode.com/problems/vowel-consonant-score/
Language: C#






public class Solution {
        public int VowelConsonantScore(string s)
        {
            int v = 0, c = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u')
                    v++;
                else if (char.IsLetter(s[i]))
                    c++;
            }

            return c == 0 ? 0 : v / c;
        }
}