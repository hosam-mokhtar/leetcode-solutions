Link: https://leetcode.com/problems/water-bottles/
Language: C#







public class Solution {
        public int NumWaterBottles(int numBottles, int numExchange)
        {
            int temp = 0;
            int result = numBottles;

            while (numBottles >= numExchange)
            {
                temp = numBottles / numExchange;
                numBottles = numBottles % numExchange + temp;

                result += temp;
            }
            return result;
        }
}