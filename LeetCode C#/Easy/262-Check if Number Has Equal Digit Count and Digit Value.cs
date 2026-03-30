Link: https://leetcode.com/problems/check-if-number-has-equal-digit-count-and-digit-value/
Language: C#






public class Solution {
        public bool DigitCount(string num)
        {
            int[] freq = new int[10];

            for (int i = 0; i < num.Length; i++)
            {
                freq[num[i] - '0']++;
            }

            string res = "";

            for (int i = 0; i < num.Length; i++)
            {
                res += freq[i];
            }

            return res == num;
        }
}