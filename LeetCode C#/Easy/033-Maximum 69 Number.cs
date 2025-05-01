Link: https://leetcode.com/problems/maximum-69-number/
Language: C#




public class Solution {
public int Maximum69Number(int num)
        {
            string s = num.ToString();
            StringBuilder sb = new StringBuilder(); 
            bool flag= false;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '6' && flag == false)
                {
                    sb.Append('9');
                    flag=true;
                }
                else sb.Append(s[i]);
            }
            return int.Parse(sb.ToString());
        }
}