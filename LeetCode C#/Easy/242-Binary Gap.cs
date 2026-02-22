Link: https://leetcode.com/problems/binary-gap/
Language: C#








public class Solution {
        public int BinaryGap(int n)
        {
            string s = Convert.ToString(n, 2);
            int c = 1;
            int max = 0;
            bool isFlag = false;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '1')
                {
                    if (!isFlag)
                        isFlag = true;
                    else
                    {
                        max = Math.Max(max, c);
                        c = 1;
                    }
                }
                else
                    c++;
            }

            return max;
        }
}