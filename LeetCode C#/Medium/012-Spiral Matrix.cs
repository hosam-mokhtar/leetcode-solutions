Link: https://leetcode.com/problems/spiral-matrix/
Language: C#





public class Solution {
        public IList<int> SpiralOrder(int[][] matrix)
        {
            List<int> res = new();
            int top = 0;
            int left = 0;
            int bottom = matrix.Length - 1;
            int right = matrix[0].Length - 1;

            while (bottom >= top && right >= left)
            {
                for (int i = left; i <= right; i++)
                {
                    res.Add(matrix[top][i]);
                }
                top++;
                for (int i = top; i <= bottom; i++)
                {
                    res.Add(matrix[i][right]);
                }
                right--;
                if (top <= bottom)
                {
                    for (int i = right; i >= left; i--)
                    {
                        res.Add(matrix[bottom][i]);
                    }
                }
                bottom--;
                if (left <= right)
                {
                    for (int i = bottom; i >= top; i--)
                    {
                        res.Add(matrix[i][left]);
                    }
                }
                left++;
            }
            return res;
        }
}