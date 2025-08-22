Link: https://leetcode.com/problems/find-the-minimum-area-to-cover-all-ones-i/
Language: C#







public class Solution {
        public int MinimumArea(int[][] grid)
        {
            int minrow = int.MaxValue,
                maxrow = int.MinValue,
                mincol = int.MaxValue,
                maxcol = int.MinValue;

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        if (minrow > i)
                            minrow = i;
                        if (maxrow < i)
                            maxrow = i;

                        if (mincol > j)
                            mincol = j;
                        if (maxcol < j)
                            maxcol = j;
                    }
                }
            }

            return (maxrow - minrow + 1) * (maxcol - mincol + 1);
        }
}