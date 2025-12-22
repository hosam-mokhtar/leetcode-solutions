Link: https://leetcode.com/problems/mirror-distance-of-an-integer/
Language: C#






public class Solution {
        public int MirrorDistance(int n)
        {
            int r = 0;
            int temp = n;

            while (temp > 0)
            {
                int i = temp % 10;
                r = 10 * r + i;
                temp /= 10;
            }

            return Math.Abs(n - r);
        }
}