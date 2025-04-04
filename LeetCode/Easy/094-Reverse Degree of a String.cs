Link: https://leetcode.com/problems/reverse-degree-of-a-string/
Language: C#




public class Solution {
        public int ReverseDegree(string s)
        {
            int sum = 0;
            for (int i = 0; i < s.Length; i++) { 
                sum += (26+'a'-s[i])*(i+1);
            }
            return sum;
        }
}