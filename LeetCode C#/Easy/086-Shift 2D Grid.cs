Link: https://leetcode.com/problems/shift-2d-grid/
Language: C#




public class Solution {
        public IList<IList<int>> ShiftGrid(int[][] grid, int k)
        {
            if (k == 0 || k == grid.Length * grid[0].Length) return grid;
            if (k > grid.Length * grid[0].Length)
                k %= (grid.Length * grid[0].Length);
            int[] res = new int[grid.Length * grid[0].Length];
            int c = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    res[c] = grid[i][j];
                    c++;
                }
            }
            Array.Reverse(res);
            Array.Reverse(res, 0, k);
            Array.Reverse(res, k, res.Length - k);
            c = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    grid[i][j] = res[c];
                    c++;
                }
            }
            return grid;
        }
}