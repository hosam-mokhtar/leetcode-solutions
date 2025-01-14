Link: https://leetcode.com/problems/number-of-1-bits/
Language: C#




public class Solution {
    public int HammingWeight(int n)
        {      
            string s=Convert.ToString(n, 2);
            int counter = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].Equals('1'))
                {
                    counter++;
                }
            }
            return counter;
        }
}