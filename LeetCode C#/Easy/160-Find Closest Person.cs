Link: https://leetcode.com/problems/find-closest-person/
Language: C#







public class Solution {
        public int FindClosest(int x, int y, int z)
        {
            int dX = Math.Abs(z - x);
            int dY = Math.Abs(z - y);
            return dX == dY ? 0 : dX < dY ? 1 : 2;
        }
}