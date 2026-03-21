Link: https://leetcode.com/problems/flip-square-submatrix-vertically/
Language: C#







public class Solution {
        public int[][] ReverseSubmatrix(int[][] grid, int x, int y, int k)
        {
            int endRow = x + k - 1;
            int endCol = y + k - 1;

            for (int i = 0; i < k / 2; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    (grid[x + i][y + j], grid[endRow - i][y + j]) =
                    (grid[endRow - i][y + j], grid[x + i][y + j]);
                }
            }

            return grid;
        }
}