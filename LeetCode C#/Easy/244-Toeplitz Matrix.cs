Link: https://leetcode.com/problems/toeplitz-matrix/
Language: C#








public class Solution {
        public bool IsToeplitzMatrix(int[][] matrix)
        {
            for (int i = 1; i < matrix.Length; i++)
            {
                for (int j = 1; j < matrix[0].Length; j++)
                {
                    if (matrix[i][j] != matrix[i - 1][j - 1])
                        return false;
                }
            }

            return true;
        }
}