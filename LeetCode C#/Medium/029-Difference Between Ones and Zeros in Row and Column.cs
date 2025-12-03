Link: https://leetcode.com/problems/difference-between-ones-and-zeros-in-row-and-column/
Language: C#







public class Solution {
        public int[][] OnesMinusZeros(int[][] grid)
        {
            int[] onesRow = new int[grid.Length];
            int[] onesCol = new int[grid[0].Length];

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    onesRow[i] += grid[i][j];
                    onesCol[j] += grid[i][j];
                }
            }

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    grid[i][j] = onesRow[i] + onesCol[j] 
                                 - (grid.Length - onesRow[i]) 
                                 - (grid[0].Length - onesCol[j]);
                }
            }

            return grid;
        }
}