Link: https://leetcode.com/problems/a-number-after-a-double-reversal/
Language: C#




public class Solution {
public bool IsSameAfterReversals(int num)
        {
            string s = num.ToString();
            StringBuilder sb =new StringBuilder();
            StringBuilder sb1 = new StringBuilder();
            for (int i= s.Length-1; i>=0;i--)
            {
                sb.Append(s[i]);
            }
            int n= int.Parse(sb.ToString());
            string s2 = n.ToString();
            for (int i = s2.Length-1; i >= 0; i--)
            {
                sb1.Append(s2[i]);
            }
            if(sb1.ToString()==num.ToString())
               return true;
          return false;
        }
}