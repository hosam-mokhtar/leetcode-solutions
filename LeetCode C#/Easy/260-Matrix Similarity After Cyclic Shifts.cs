Link: https://leetcode.com/problems/matrix-similarity-after-cyclic-shifts/
Language: C#








public class Solution {
        public bool AreSimilar(int[][] mat, int k)
        {
            if (k % mat[0].Length == 0) return true;

            for (int i = 0; i < mat.Length; i++)
            {
                for (int j = 0; j < mat[0].Length; j++)
                {
                    if (mat[i][j] != mat[i][(j + k) % mat[0].Length])
                        return false;
                }
            }

            return true;
        }
}