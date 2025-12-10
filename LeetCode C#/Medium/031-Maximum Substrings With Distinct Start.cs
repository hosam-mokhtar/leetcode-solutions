Link: https://leetcode.com/problems/maximum-substrings-with-distinct-start/
Language: C#







public class Solution {
        public int MaxDistinct(string s)
        {
            bool[] freq = new bool[26];
            
            for (int i = 0; i < s.Length; i++)
            {
                freq[s[i] - 'a'] = true;
            }

            return freq.Where(w => w).Count();
        }
}