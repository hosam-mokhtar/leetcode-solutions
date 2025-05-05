Link: https://leetcode.com/problems/first-unique-character-in-a-string/
Language: C#






public class Solution {
        public int FirstUniqChar(string s)
        {
            int minValue = int.MaxValue;
            for (char i = 'a'; i <= 'z'; i++)
            {
                if (s.Contains(i))
                {
                    if (s.IndexOf(i) == s.LastIndexOf(i))
                        minValue = Math.Min(s.IndexOf(i), minValue);
                    if (minValue == 0) break;
                }
            }
            return minValue == int.MaxValue ? -1 : minValue;
        }
}