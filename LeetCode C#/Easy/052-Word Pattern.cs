Link: https://leetcode.com/problems/word-pattern/
Language: C#




public class Solution {
        public bool WordPattern(string pattern, string s) {
            var d = new Dictionary<char, string>();
            string[] word = s.Split(' ');
            if (word.Length != pattern.Length) return false;
            int c = 0;
            for (int i = 0; i < pattern.Length; i++)
            {
                if (!d.ContainsKey(pattern[i]))
                    if (!d.ContainsValue(word[c]))
                    {
                        d.Add(pattern[i], word[c]);
                        c++;
                    }
                    else return false;    
                else if (d[pattern[i]] == word[c])
                    c++;
                else
                    return false;
            }
            return true;
        }
}