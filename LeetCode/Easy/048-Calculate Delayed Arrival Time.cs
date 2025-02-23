Link: https://leetcode.com/problems/calculate-delayed-arrival-time/
Language: C#


public class Solution {
        public int FindDelayedArrivalTime(int arrivalTime, int delayedTime)
        {
            return (arrivalTime + delayedTime) % 24;
        }
}