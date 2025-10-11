Link: https://leetcode.com/problems/minimum-time-to-type-word-using-special-typewriter/
Language: C#







public class Solution {
        public int MinTimeToType(string word)
        {
            int time = word.Length;

            time += Math.Min(Math.Abs(word[0] - 'a'), Math.Abs(word[0] - 'z') + 1);
            
            for (int i = 1; i < word.Length; i++)
            {
                int d1 = Math.Abs(word[i] - 'a') + Math.Abs('z' - word[i - 1]) + 1;
                int d2 = Math.Abs(word[i] - 'z') + Math.Abs('a' - word[i - 1]) + 1;
                int d3 = Math.Abs(word[i] - word[i - 1]);

                time += Math.Min(Math.Min(d1, d2), d3);
            }

            return time;
        }
}