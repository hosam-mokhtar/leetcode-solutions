Link: https://leetcode.com/problems/binary-gap/
Language: C#








public class Solution {
        public int BinaryGap(int n)
        {
            int c = 1;
            int max = 0;
            bool isCount = false;
            int LSP = n & 1;

            while (n > 0)
            {
                if (LSP == 1)
                {
                    if (isCount)
                    {
                        max = Math.Max(max, c);
                        c = 1;
                    }
                    else
                        isCount = true;
                }
                else if (isCount)
                    c++;

                n >>= 1;
                LSP = n & 1;
            }

            return max;
        }
}