Link: https://leetcode.com/problems/score-of-a-string/
Language: C#





public class Solution {
    public int ScoreOfString(string s) {
        int sum = 0;
for (int i = 1; i < s.Length; i++)
{
     sum += Math.Abs(s[i-1] - s[i]);

}
return sum;
    }
}