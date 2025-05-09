Link: https://leetcode.com/problems/modify-the-matrix/
Language: C#







public class Solution {
        public int[][] ModifiedMatrix(int[][] matrix)
        {
            int[] maxColumns = new int[matrix[0].Length];

            for (int i = 0; i < matrix[0].Length; i++)
            {
                int maxValue = int.MinValue;

                for (int j = 0; j < matrix.Length; j++)
                {
                    maxValue = Math.Max(maxValue, matrix[j][i]);
                }

                maxColumns[i] = maxValue;

                for (int j = 0; j < matrix.Length; j++)
                {
                    if (matrix[j][i] == -1)
                        matrix[j][i] = maxColumns[i];
                }
            }
            return matrix;
        }
}