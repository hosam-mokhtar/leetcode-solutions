Link: https://leetcode.com/problems/find-most-frequent-vowel-and-consonant/
Language: C#






public class Solution {
        public int MaxFreqSum(string s)
        {
            int maxConstants = 0;
            int maxVowels = 0;
            int[] freq = new int[26];

            for (int i = 0; i < s.Length; i++)
            {
                freq[s[i] - 'a']++;
            }

            for (int i = 0; i < freq.Length; i++)
            {
                if (i + 'a' == 'a' || i + 'a' == 'e' || i + 'a' == 'i' || i + 'a' == 'o' || i + 'a' == 'u')
                {
                    if (maxVowels < freq[i])
                        maxVowels = freq[i];
                }
                else
                {
                    if (maxConstants < freq[i])
                        maxConstants = freq[i];
                }
            }

            return maxConstants + maxVowels;
        }
}