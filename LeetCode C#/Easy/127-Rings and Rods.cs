Link: https://leetcode.com/problems/rings-and-rods/
Language: C#






public class Solution {
        public int CountPoints(string rings)
        {
            int numberOfRods = 0;
            string[] freq = new string[51];

            for (int i = rings.Length - 1; i >= 0; i-=2)
            {
                    freq[rings[i] - '0'] += rings[i - 1];
            }

            for (int i = 0; i < freq.Length; i++)
            {
                if (freq[i] != null && freq[i].Contains('R') 
                && freq[i].Contains('G') && freq[i].Contains('B'))
                    numberOfRods++;
            }
            
            return numberOfRods;
        }
}
