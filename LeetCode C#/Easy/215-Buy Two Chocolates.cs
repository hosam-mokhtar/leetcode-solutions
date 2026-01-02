Link: https://leetcode.com/problems/buy-two-chocolates/
Language: C#








public class Solution {
        public int BuyChoco(int[] prices, int money)
        {
            int min1 = int.MaxValue, min2 = int.MaxValue;

            foreach (int num in prices)
            {
                if (num < min1)
                {
                    min2 = min1;
                    min1 = num;
                }
                else if (num < min2)
                    min2 = num;
            }

            return min1 + min2 > money ? money : money - min1 - min2;
        }
}