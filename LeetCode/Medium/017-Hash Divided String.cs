Link: https://leetcode.com/problems/hash-divided-string/
Language: C#






public class Solution {
        public string StringHash(string s, int k)
        {
            StringBuilder result = new StringBuilder();
            int sum = 0;
            int counter = 0;
            for (int i = 0; i < s.Length; i++)
            {
                counter++;
                sum += s[i] - 'a';
                if (counter == k)
                {
                    counter = 0;
                    result.Append((char)((sum % 26) + 'a'));
                    sum = 0;
                }
            }
            return result.ToString();
        }
}