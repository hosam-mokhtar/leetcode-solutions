Link: https://leetcode.com/problems/reverse-integer/
Language: C#






public class Solution {
  public int Reverse(double x)
        {
         
            if (x < int.MinValue || x > int.MaxValue)
            { return 0; }
            var sign = 1;
            StringBuilder sb = new StringBuilder();
            StringBuilder sbcopy= new StringBuilder();   
            if (x < 0)
            {
                sign = -1;
                x *= -1;
                sb.Append(x);
            }
            else
            {
                sb.Append(x);
            }
            for (int i = sb.Length - 1; i >= 0; i--)
            {
                sbcopy.Append(sb[i]);
            }
            if (int.MaxValue < double.Parse(sbcopy.ToString())*sign || int.MinValue > double.Parse(sbcopy.ToString())*sign)
            {
                return 0;
            }
            return int.Parse(sbcopy.ToString()) * sign;
        }
}
