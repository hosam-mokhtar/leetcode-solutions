Link: https://leetcode.com/problems/string-matching-in-an-array/
Language: C#







public class Solution {
        public IList<string> StringMatching(string[] words)
        {
            List<string> result = new List<string>();

            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < words.Length; j++)
                {
                    if (i != j && words[j].Contains(words[i]))
                    {
                        result.Add(words[i]);
                        break;
                    }
                }
            }

            return result;
        }
}