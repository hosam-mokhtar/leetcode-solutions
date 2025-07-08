Link: https://leetcode.com/problems/check-if-it-is-a-straight-line/
Language: C#







public class Solution {
        public bool CheckStraightLine(int[][] coordinates)
        {
            for (int i = 0; i < coordinates.Length - 2; i++)
            {
                if ((coordinates[i+2][1] - coordinates[i+1][1]) * 
                    (coordinates[i+1][0] - coordinates[i][0]) !=
                    (coordinates[i+1][1] - coordinates[i][1]) * 
                    (coordinates[i+2][0] - coordinates[i+1][0]))
                    return false;
            }
            return true;
        }
}