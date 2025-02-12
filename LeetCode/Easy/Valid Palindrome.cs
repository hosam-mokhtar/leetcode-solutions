Link: https://leetcode.com/problems/valid-palindrome/description/
Language: C#

public class Solution {
public bool IsPalindrome(string s)
        {
            //ASCII table
            // a to z || A to Z || 0 to 9
            //foreach (char c in s)
            //{
            //    if (char.IsLetterOrDigit(c))
            //    {
            //        sb.Append(c.ToString().ToLower());
            //    }
            //}
            // OR
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
            Console.WriteLine(sb.ToString());   
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