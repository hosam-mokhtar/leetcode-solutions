Link: https://leetcode.com/problems/cells-in-a-range-on-an-excel-sheet/
Language: C#







public class Solution {
        public IList<string> CellsInRange(string s)
        {
            string[] result = new string[(s[3] - s[0] + 1) * (s[4] - s[1] + 1)];

            int num = s[1] - '0';
            char ch = s[0];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = ch + num++.ToString();

                if (num > s[4] - '0')
                {
                    num = s[1] - '0';
                    ch++; 
                }
            }

            return result;
        }
}