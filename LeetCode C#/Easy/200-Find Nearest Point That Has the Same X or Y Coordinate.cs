Link: https://leetcode.com/problems/find-nearest-point-that-has-the-same-x-or-y-coordinate/
Language: C#







public class Solution {
        public int NearestValidPoint(int x, int y, int[][] points)
        {
            int index = -1;
            int minDistance = int.MaxValue;

            for (int i = 0; i < points.Length; i++)
            {
                int pX = points[i][0];
                int pY = points[i][1];
                if (x == pX || y == pY)
                {
                    int distance = Math.Abs(x - pX) + Math.Abs(y - pY);

                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        index = i;
                    }
                }
            }

            return index;
        }
}