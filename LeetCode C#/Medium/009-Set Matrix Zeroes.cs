Link: https://leetcode.com/problems/set-matrix-zeroes/
Language: C#





public class Solution {
        public void SetZeroes(int[][] matrix)
        {   
            int [] rows = new int[matrix.Length];
            int [] cols = new int[matrix[0].Length];
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        rows[i]++;
                        cols[j]++;
                    }
                }
            }
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (rows[i]>0 || cols[j]>0)
                        matrix[i][j] = 0;
                }
            }
        }
}