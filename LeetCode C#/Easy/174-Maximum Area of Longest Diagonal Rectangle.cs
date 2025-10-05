Link: https://leetcode.com/problems/maximum-area-of-longest-diagonal-rectangle/
Language: C#







public class Solution {
        public int AreaOfMaxDiagonal(int[][] dimensions)
        {
            double maxDiagonal = 0;
            int maxArea = 0;

            for (int i = 0; i < dimensions.Length; i++)
            {
                double DiagonalLength = (dimensions[i][0] * dimensions[i][0]) + 
                                        (dimensions[i][1] * dimensions[i][1]);
                if (DiagonalLength > maxDiagonal)
                {
                    maxDiagonal = DiagonalLength;
                    maxArea = dimensions[i][0] * dimensions[i][1];
                }
                else if (DiagonalLength == maxDiagonal)
                {
                    maxDiagonal = DiagonalLength;
                    maxArea = Math.Max(maxArea, dimensions[i][0] * dimensions[i][1]);
                }
            }

            return maxArea;
        }
}