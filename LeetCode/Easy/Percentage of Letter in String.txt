Link: https://leetcode.com/problems/percentage-of-letter-in-string/
Language: C#





public class Solution {
   public int PercentageLetter(string s, char letter)
{
    int counter = 0;
    for (int i = 0; i < s.Length; i++)
    {
        if (s[i] == letter)
            counter++;
    }
    return (counter *100/ s.Length);
}
}