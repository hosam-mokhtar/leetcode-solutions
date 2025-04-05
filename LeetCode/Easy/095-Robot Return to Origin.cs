Link: https://leetcode.com/problems/robot-return-to-origin/
Language: C#





public class Solution {
        public bool JudgeCircle(string moves)
        {
            Span <int> freq = stackalloc int [26];
            for (int i = 0; i < moves.Length; i++)
            {
                freq[moves[i] - 'A']++;
            }
            return (freq['R' - 'A'] - freq['L' - 'A'] == 0) && (freq['U' - 'A'] - freq['D' - 'A'] == 0);
        }
}