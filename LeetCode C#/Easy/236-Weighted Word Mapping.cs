Link: https://leetcode.com/problems/weighted-word-mapping/
Language: C#







public class Solution {
        public string MapWordWeights(string[] words, int[] weights)
        {
            char[] chars = new char[words.Length];

            for (int i = 0; i < words.Length; i++)
            {
                int sum = 0;

                for (int j = 0; j < words[i].Length; j++)
                {
                    sum += weights[words[i][j] - 'a'];
                }

                chars[i] = (char)(122 - sum % 26);
            }

            return new string(chars);
        }
}