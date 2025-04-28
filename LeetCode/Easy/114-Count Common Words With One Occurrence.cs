Link: https://leetcode.com/problems/count-common-words-with-one-occurrence/
Language: C#






public class Solution {
        public int CountWords(string[] words1, string[] words2)
        {   
            int counter = 0;
            Dictionary<string, int> dict = [];
            Dictionary<string, int> dict2 = [];
            for (int i = 0; i < words1.Length; i++)
            {
                if (!dict.TryAdd(words1[i], 1))
                    dict[words1[i]]++;
            }
            for (int i = 0; i < words2.Length; i++)
            {
                if (!dict2.TryAdd(words2[i], 1))
                    dict2[words2[i]]++;
            }
            for (int i = 0; i < words1.Length; i++)
            {
                if (dict.ContainsKey(words1[i]) && dict[words1[i]] == 1
                    && dict2.ContainsKey(words1[i]) && dict2[words1[i]] == 1)
                    counter++;
            }
            return counter;
        }
}