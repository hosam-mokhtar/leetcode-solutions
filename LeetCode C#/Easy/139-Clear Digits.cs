Link: https://leetcode.com/problems/clear-digits/
Language: C#






public class Solution {
        public string ClearDigits(string s)
        {
            char[] chars = new char[s.Length];
            int index = 0;
            
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsLetter(s[i]))
                {
                    chars[index] = s[i];
                    index++;
                }
                else
                {
                    index--;
                }
            }

            return new string(chars, 0, index);
        }
}