Link: https://leetcode.com/problems/base-7/
Language: C#




public class Solution {
        public string ConvertToBase7(int num)
        {
            if (num == 0) return "0";
            bool flag = num < 0;
            if (flag)
                num = Math.Abs(num);
            StringBuilder sb = new StringBuilder();
            while (num > 0)
            {
                sb.Insert( 0,num % 7);
                num /= 7;
            }
            return flag ? ("-" + sb.ToString()) : sb.ToString();
        }
}