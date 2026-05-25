Link: https://leetcode.com/problems/camelcase-matching
Language: C#







public class Solution {
        public IList<bool> CamelMatch(string[] queries, string pattern)
        {
            bool[] result = new bool[queries.Length];

            for (int i = 0; i < queries.Length; i++)
            {
                int index = 0;
                bool valid = true;

                for (int j = 0; j < queries[i].Length; j++)
                {
                    char ch = queries[i][j];

                    if (index < pattern.Length && ch == pattern[index])
                        index++;
                    else if (char.IsUpper(ch))
                    {
                        valid = false;
                        break;
                    }
                }

                result[i] = valid && index == pattern.Length;
            }

            return result;
        }
}