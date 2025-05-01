Link: https://leetcode.com/problems/check-if-all-characters-have-equal-number-of-occurrences/
Language: C#







public class Solution {
        public bool AreOccurrencesEqual(string s)
        {
            int[] freq = new int[26];
            int counter = 0;
            bool check = false; 
            for (int i = 0; i < s.Length; i++)
            {
                freq[s[i] - 'a']++;
            }
            for (int i = 0; i < freq.Length; i++)
            {
                if (check == false && freq[i] > 0)
                {
                    counter = freq[i];
                    check = true;
                }
                if (freq[i] > 0 && counter != freq[i])
                    return false;
            }
            return true;
        }
}