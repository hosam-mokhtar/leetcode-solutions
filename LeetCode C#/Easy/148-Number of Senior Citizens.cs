Link: https://leetcode.com/problems/number-of-senior-citizens/
Language: C#







public class Solution {
        public int CountSeniors(string[] details)
        {
            int numberOfPassengers = 0;

            for (int i = 0; i < details.Length; i++)
            {
                if ((details[i][11]-'0')*10 + (details[i][12]-'0') > 60)
                    numberOfPassengers++;
            }
            return numberOfPassengers;
        }
}