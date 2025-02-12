Link: https://leetcode.com/problems/rotate-image/
Language: C#




public class Solution {
public void Rotate(int[][] matrix)
        {
            var x = matrix.GetLength(0);
            var temp=0;
            for (int i=0;ix;i++)
            {
                for (int j = i+1; j  x; j++)
                {
                    temp = matrix[i][j];
                    matrix[i][j] = matrix[j][i] ;
                    matrix[j][i] = temp;
                }
            }
            for (int i = 0; i  x; i++)
            {
                Array.Reverse(matrix[i]);
            }
        }
}