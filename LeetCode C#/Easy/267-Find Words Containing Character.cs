Link: https://leetcode.com/problems/find-words-containing-character/
Language: C#








public class Solution {
        public IList<int> FindWordsContaining(string[] words, char x)
        {
            List<int> list = [];
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Contains(x))
                    list.Add(i);
            }
            return list;
        }
}