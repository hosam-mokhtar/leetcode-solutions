Link: https://leetcode.com/problems/second-largest-digit-in-a-string/
Language: C#






public class Solution {
        public int SecondHighest(string s)
        {
            bool[] digits = new bool[10];

            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsDigit(s[i]))
                    digits[s[i] - '0'] = true;
            }

            bool largestNumber = false;

            for (int i = 9; i >= 0; i--)
            {
                if (digits[i] && !largestNumber)
                    largestNumber = true;
                else if (digits[i])
                    return i;
            }

            return -1;
        }
}