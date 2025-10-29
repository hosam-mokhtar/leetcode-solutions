Link: https://leetcode.com/problems/smallest-number-with-all-set-bits/
Language: C#







public class Solution {
        public int SmallestNumber(int n)
        {
           /*   
            string s=Convert.ToString(n,2);
            StringBuilder sb=new StringBuilder();
            for (int i = 0; i < s.Length; i++) {
                sb.Append('1');    
            }
            return Convert.ToInt32(sb.ToString(),2);
            */
            
        int x = 1;

        while (x < n)
            x = (x << 1) | 1;
        
        return x;
        }
}