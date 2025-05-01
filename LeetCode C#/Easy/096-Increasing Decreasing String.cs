Link: https://leetcode.com/problems/increasing-decreasing-string/
Language: C#



public class Solution {
        public string SortString(string s)
        {
            StringBuilder sb = new StringBuilder();
            int[] freq = new int[26];
            for (int i = 0; i < s.Length; i++)
            {
                freq[s[i] - 'a']++;
            }
            while (sb.Length < s.Length)
            {
                for (int i = 0; i < freq.Length; i++)
                {
                    if (freq[i] > 0)
                    {
                        sb.Append((char)(i+'a'));
                        freq[i]--;
                    }
                }
                for (int i = freq.Length - 1; i >= 0; i--)
                {
                    if (freq[i] > 0)
                    {
                        sb.Append((char)(i+'a'));
                        freq[i]--;
                    }
                }
            }
            return sb.ToString();
        }
}