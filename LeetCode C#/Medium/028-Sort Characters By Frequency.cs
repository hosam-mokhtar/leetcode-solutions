Link: https://leetcode.com/problems/sort-characters-by-frequency/
Language: C#






public class Solution {
        public string FrequencySort(string s)
        {
            int[] ascii = new int[123];
            StringBuilder sb = new();

            for (int i = 0; i < s.Length; i++)
            {
                ascii[s[i]]++;
            }

            int max = ascii.Max();

            while (max > 0)
            {
                for (int i = 48; i < 123; i++)
                {
                    if (ascii[i] == max)
                    {
                        while (ascii[i] > 0)
                        {
                            sb.Append((char)i);
                            ascii[i]--;
                        }
                    }
                }

                max = ascii.Max();
            }

            return sb.ToString();
        }
}