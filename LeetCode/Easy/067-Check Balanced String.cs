Link: https://leetcode.com/problems/check-balanced-string/
Language: C#





public class Solution {
        public bool IsBalanced(string num)
        {
            int even_sum = 0; 
            int odd_sum = 0;
            for (int i = 0; i < num.Length; i++) { 
                if(i%2==0)
                    even_sum += num[i]-'0';
                else 
                    odd_sum += num[i]-'0';       
            }
            return even_sum == odd_sum;
        }
}