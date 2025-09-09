Link: https://leetcode.com/problems/substrings-of-size-three-with-distinct-characters/
Language: C#







public class Solution {
        public int CountGoodSubstrings(string s)
        {
            StringBuilder sb = new StringBuilder(3);
            int counter = 0;

            for (int i = 0; i < s.Length; i++)
            {
                sb.Append(s[i]);

                if (sb.Length == 3)
                {
                    if (sb[0] != sb[1] && sb[0] != sb[2] && sb[1] != sb[2])
                        counter++;

                    sb.Remove(0, 1);
                }
            }

            return counter;
        }
}