Link: https://leetcode.com/problems/convert-1d-array-into-2d-array/
Language: C#






public class Solution {
        public int[][] Construct2DArray(int[] original, int m, int n)
        {
            if (n * m != original.Length) return [];
            int c = 0;
            int[][] result = new int[m][];
            for (int i = 0; i < m; i++)
            {
                result[i] = new int[n];
                for (int j = 0; j < n; j++)
                {
                    result[i][j] = original[c];
                    c++;
                }
            }
            return result;
        }
}