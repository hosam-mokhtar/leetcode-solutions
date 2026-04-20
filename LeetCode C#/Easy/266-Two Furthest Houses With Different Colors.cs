Link: https://leetcode.com/problems/two-furthest-houses-with-different-colors/
Language: C#









public class Solution {
        public int MaxDistance(int[] colors)
        {
            for (int i = 0; i < colors.Length; i++)
            {
                int j = colors.Length - 1;
                if (colors[i] != colors[j] || colors[j - i] != colors[0])
                    return j - i;
            }

            return 0;
        }
}