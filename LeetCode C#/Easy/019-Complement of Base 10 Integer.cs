Link: https://leetcode.com/problems/complement-of-base-10-integer/
Language: C#




public class Solution {
   public int BitwiseComplement(int n)
        {
            string s= Convert.ToString(n, 2);
            StringBuilder sb = new StringBuilder();
            for(int i=0;i<s.Length;i++)
            {
                if (s[i] == '1')
                {
                    sb.Append('0');
                }
                else
                {
                    sb.Append('1');
                }
            }
            return Convert.ToInt32(sb.ToString(),2);
        }
}