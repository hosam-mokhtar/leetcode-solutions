Link: https://leetcode.com/problems/check-if-the-number-is-fascinating/
Language: C#



public class Solution {
        public bool IsFascinating(int n)
        {   
            string s = "";
            for (int i = 1; i < 4; i++)
            {  
                s += (n * i).ToString();
            }
            if (s.Length > 9)
                return false;
            for (int i = 1; i < 10; i++)
            {
                if (!s.Contains(i.ToString()))
                    return false;
            }
            return true;
        }
}