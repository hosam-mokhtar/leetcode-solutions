Link: https://leetcode.com/problems/to-lower-case/
Language: C#




public class Solution {
public string ToLowerCase(string s)
        {   
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                // alphabet =26 characters
                // A to Z = 65 to 90 , a to z = 97 to 122 

                if (s[i] > 64 && s[i]<91)
                {
                    sb.Append((char)(s[i] + 32));             
                }
                else
                {
                    sb.Append(s[i]);
                }
            }
            return sb.ToString();
            /*OR 
            return s.ToLower();
            */
        }
}