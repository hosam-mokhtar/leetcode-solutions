Link: https://leetcode.com/problems/reverse-prefix-of-word/
Language: C#






public class Solution {
        public string ReversePrefix(string word, char ch)
        {
            char[] chars = word.ToCharArray();
            int index = 0;

            for (int i = 0; i < word.Length; i++)
            {
                if (chars[i] == ch)
                {
                    index = i;
                    break;
                }
            }

            int c = 0;

            while (c <= index)
            {
                (chars[c], chars[index]) = (chars[index], chars[c]);
                c++;
                index--;
            }

            return new string(chars);
        }
}