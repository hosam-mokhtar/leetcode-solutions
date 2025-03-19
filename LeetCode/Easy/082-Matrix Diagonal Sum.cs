Link: https://leetcode.com/problems/matrix-diagonal-sum/
Language: C#





public class Solution {
        public int DiagonalSum(int[][] mat)
        {
            int sum = 0;
            for (int i = 0; i < mat.Length; i++)
            {
                sum += mat[i][i];
                if (i != mat.Length - 1 - i)
                    sum += mat[i][mat.Length - 1 - i];
            }
            return sum;
        }
}