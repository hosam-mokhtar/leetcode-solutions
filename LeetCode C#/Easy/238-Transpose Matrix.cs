Link: https://leetcode.com/problems/transpose-matrix/
Language: C#








public class Solution {
    public int[][] Transpose(int[][] matrix)
    {
        int[][] ans = new int[matrix[0].Length][];

        for (int i = 0; i < matrix[0].Length; i++)
        {
            ans[i] = new int[matrix.Length];
        }

        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[0].Length; j++)
            {
                ans[j][i] = matrix[i][j];
            }
        }

        return ans;
    }
}