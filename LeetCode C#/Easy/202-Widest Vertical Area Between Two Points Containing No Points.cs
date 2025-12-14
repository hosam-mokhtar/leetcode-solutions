Link: https://leetcode.com/problems/widest-vertical-area-between-two-points-containing-no-points/
Language: C#







public class Solution {
        public int MaxWidthOfVerticalArea(int[][] points)
        {
            Array.Sort(points, (p1, p2) => p1[0] - p2[0]);
            int area = 0;

            for (int i = 0; i < points.Length - 1; i++)
            {
                area = Math.Max(area, Math.Abs(points[i + 1][0] - points[i][0]));
            }

            return area;
        }
}