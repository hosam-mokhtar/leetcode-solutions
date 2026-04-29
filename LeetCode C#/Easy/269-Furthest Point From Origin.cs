Link: https://leetcode.com/problems/furthest-point-from-origin/
Language: C#





public class Solution
{
    public int FurthestDistanceFromOrigin(string moves)
    {
        int c = 0;
        int underScore = 0;

        foreach (var move in moves)
        {
            if (move == 'R')
                c++;
            else if (move == 'L')
                c--;
            else
                underScore++;
        }

        return Math.Abs(c) + underScore;
    }
}