Link: https://leetcode.com/problems/maximum-odd-binary-number/
Language: C#





public class Solution {
        public string MaximumOddBinaryNumber(string s)
        {
            int counter = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '1')
                    counter++;
            }
            StringBuilder maxNumber = new StringBuilder();
            for (int i = 0; i < s.Length - 1; i++)
            {
                if (counter > 1)
                {
                    maxNumber.Append('1');
                    counter--;
                }
                else
                    maxNumber.Append('0');
            }
            maxNumber.Append('1');
            return maxNumber.ToString();         
       //   return new string('1',counter-1) + new string('0',s.Length-counter) + "1";
        }
}