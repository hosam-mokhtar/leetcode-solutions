Link: https://leetcode.com/problems/check-if-strings-can-be-made-equal-with-operations-i/
Language: C#







public class Solution {
        public bool CanBeEqual(string s1, string s2)
        {
            if (s1 == s2) return true;

            char[] chars = s1.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                for (int j = 0; j < chars.Length; j++)
                {
                    if (Math.Abs(i - j) == 2)
                    {
                        (chars[i], chars[j]) = (chars[j], chars[i]);

                        if (new string(chars) == s2)
                            return true;
                    }
                }
            }

            return false;
        }
}