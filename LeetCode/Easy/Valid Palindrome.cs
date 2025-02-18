Link: https://leetcode.com/problems/valid-palindrome/
Language: C#

public class Solution {
public bool IsPalindrome(string s) {
            StringBuilder sb = new StringBuilder();
            foreach (char c in s)
            {
                if (c >= 65 && c <= 90)
                {
                    sb.Append(c.ToString().ToLower());
                }
                else if (c >= 'a' && c <= 'z' || c >= 48 && c <= 57)
                {
                    sb.Append(c);
                }
            } 
            for(int i=0;i<sb.Length/2;i++)
            {
                if (sb[i] != sb[sb.Length-1-i])
                {
                    return false;
                }
            }
       return true;
        }
}