Link: https://leetcode.com/problems/adding-spaces-to-a-string/
Language: C#






public class Solution {
        public string AddSpaces(string s, int[] spaces)
        {
            char[] chars = new char [s.Length+spaces.Length];
            int c = 0;
            int index = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (c < spaces.Length && i == spaces[c])
                {
                    chars[index++] = ' ';
                    chars[index++] = s[i];
                    c++;
                }
                else
                    chars[index++] = s[i];
            }
            return new string(chars);
        }
}