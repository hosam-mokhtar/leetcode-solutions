Link: https://leetcode.com/problems/check-whether-two-strings-are-almost-equivalent/
Language: C#






public class Solution {
        public bool CheckAlmostEquivalent(string word1, string word2)
        {
            int[] freq = new int[26];
            int[] freq2 = new int[26];
            for (int i = 0; i < word1.Length; i++)
            {
                freq[word1[i] - 'a']++;
                freq2[word2[i] - 'a']++;
            }
            for (int i = 0; i < freq.Length; i++)
            {
                if (Math.Abs(freq[i] - freq2[i]) > 3)
                    return false;
            }
            return true;
        }
}