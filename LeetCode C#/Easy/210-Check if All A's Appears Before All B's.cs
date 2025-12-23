Link: https://leetcode.com/problems/check-if-all-as-appears-before-all-bs/
Language: C#








public class Solution {
        public bool CheckString(string s)
        {
            bool a = false;

            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] == 'a')
                    a = true;
                else if (a && s[i] == 'b')
                    return false;
            }

            return true;
        }
}