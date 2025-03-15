Link: https://leetcode.com/problems/number-of-laser-beams-in-a-bank/
Language: C#



public class Solution {
        public int NumberOfBeams(string[] bank)
        {
            int temp = 0;
            int sum = 0;
            for (int i = 0; i < bank.Length; i++)
            {
                int x = 0;
                for (int j = 0; j < bank[i].Length; j++)
                {
                    if (bank[i][j] - '0' == 1)
                        x += 1;
                }
                if (x != 0)
                {
                    sum += temp * x;
                    temp = x;
                }
            }
            return sum;
        }
}