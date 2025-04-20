Link: https://leetcode.com/problems/consecutive-characters/
Language: C#






public class Solution {
        public int MaxPower(string s)
        {
            if (s.Length == 1) return 1;
            int power = 0;
            int maxPower = 0;
            for (int i = 0; i < s.Length - 1; i++)
            {
                if (s[i] == s[i + 1])
                    power++;
                else
                    power = 0;
                maxPower = Math.Max(maxPower, power + 1);
            }
            return maxPower;
        }
}