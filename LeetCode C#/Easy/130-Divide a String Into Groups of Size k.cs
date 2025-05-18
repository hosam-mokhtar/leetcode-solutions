Link: https://leetcode.com/problems/divide-a-string-into-groups-of-size-k/
Language: C#





public class Solution {
        public string[] DivideString(string s, int k, char fill)
        {
            int len = s.Length / k;
            
            while (len != (float)s.Length / k)
            {
                s += fill;
                len = s.Length / k;
            }

            string[] result = new string[len];
            int index = 0;

            for (int i = 0; i < s.Length; i += k)
            {
                result[index] = s.Substring(i, k);
                index++;
            }
            return result;
        }
}