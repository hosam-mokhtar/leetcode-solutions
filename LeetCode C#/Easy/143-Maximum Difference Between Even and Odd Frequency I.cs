Link: https://leetcode.com/problems/maximum-difference-between-even-and-odd-frequency-i/
Language: C#






public class Solution {
        public int MaxDifference(string s)
        {
            int[] freq = new int[26];

            for (int i = 0; i < s.Length; i++)
            {
                freq[s[i] - 'a']++;
            }

            int maxOdd = 0;
            int maxEven = int.MaxValue;
            
            for (int i = 0; i < freq.Length; i++)
            {
                if (freq[i] == 0)
                    continue;
                else if (freq[i] % 2 == 0)
                {
                    if (maxEven > freq[i])
                        maxEven = freq[i];
                }
                else
                {
                    if (maxOdd < freq[i])
                        maxOdd = freq[i];
                }
            }

            return maxOdd - maxEven;
        }
}