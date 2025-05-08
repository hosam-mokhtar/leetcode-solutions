Link: https://leetcode.com/problems/largest-local-values-in-a-matrix/
Language: C#






public class Solution {
        public int[][] LargestLocal(int[][] grid)
        {
            int n = grid.Length - 2;
            int[][] result = new int[n][];

            for (int i = 0; i < n; i++)
            {
                result[i] = new int[n];
                for (int j = 0; j < n; j++)
                {
                    int maxValue = int.MinValue;
                    for (int k = i; k < i + 3; k++)
                    {
                        for (int l = j; l < j + 3; l++)
                        {
                            maxValue = Math.Max(maxValue, grid[k][l]);
                        }
                    }
                    result[i][j] = maxValue;
                }
            }
            return result;
        }
}