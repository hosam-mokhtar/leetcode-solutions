Link: https://leetcode.com/problems/count-tested-devices-after-test-operations/
Language: C#







public class Solution {
        public int CountTestedDevices(int[] batteryPercentages)
        {
            int counter = 0;

            for (int i = 0; i < batteryPercentages.Length; i++)
            {
                if (batteryPercentages[i] > counter)
                    counter++;
            }

            return counter;
        }
}