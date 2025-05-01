Link: https://leetcode.com/problems/check-if-a-word-occurs-as-a-prefix-of-any-word-in-a-sentence/
Language: C#





public class Solution {
        public int IsPrefixOfWord(string sentence, string searchWord)
        {  
            string[]words=sentence.Split(" ",sentence.Length);
            for (int i = 0; i < words.Length; i++) {
                if (searchWord.Length <= words[i].Length)
                {
                 if(words[i].StartsWith(searchWord))
                    return i + 1;
                }
            }
            return -1;
        }
}


