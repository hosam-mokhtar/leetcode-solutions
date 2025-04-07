Link: https://leetcode.com/problems/check-if-digits-are-equal-in-string-after-operations-i/
Language: C#






public class Solution {
        public bool HasSameDigits(string s)
        {   
            while (s.Length > 2)
            {
                char []temp = new char[s.Length-1];
                byte c=0;
                for (int i = 0; i < s.Length - 1; i++)
                {
                  temp[c++]=(char)(((int)s[i] + (int)s[i+1]) % 10);
                }
                s = new string(temp);
            }
            return s[0] == s[1];
        }
}