Link: https://leetcode.com/problems/number-of-even-and-odd-bits/
Language: C#







public class Solution {
        public int[] EvenOddBit(int n)
        {
            int even = 0, odd = 0; 
            short counter = 0;

            while (n > 0)
            {
                int x = n & 1;
                n >>= 1;

                if (x == 1)
                {
                    if (counter % 2 == 0)
                        even++;
                    else
                        odd++;
                }

                counter++;
            }

            return [even, odd];
        }
}