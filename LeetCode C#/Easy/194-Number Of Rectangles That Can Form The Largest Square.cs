Link: https://leetcode.com/problems/number-of-rectangles-that-can-form-the-largest-square/
Language: C#







public class Solution {
    public int CountGoodRectangles(int[][] rectangles)
    {
        int[] lengthSide = new int[rectangles.Length];
        int max = 0;
        int counter = 0;

        for (int i = 0; i < rectangles.Length; i++)
        {
            lengthSide[i] = Math.Min(rectangles[i][0], rectangles[i][1]);
            if (lengthSide[i] > max)
                max = lengthSide[i];
        }

        for (int i = 0; i < lengthSide.Length; i++)
        {
            if (lengthSide[i] == max)
                counter++;
        }

        return counter;
    }
}