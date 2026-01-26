Link: https://leetcode.com/problems/minimum-number-of-steps-to-make-two-strings-anagram/
Language: C#







public class Solution {
        public int MinSteps(string s, string t)
        {
            int[] freqS = new int[26];
            int steps = 0;

            for (int i = 0; i < s.Length; i++)
            {
                freqS[s[i] - 'a']++;
                freqS[t[i] - 'a']--;
            }

            foreach (var i in freqS)
            {
                if (i > 0)
                    steps += i;
            }

            return steps;
        }
}