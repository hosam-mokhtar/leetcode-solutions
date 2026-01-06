Link: https://leetcode.com/problems/largest-even-number/
Language: C#






public class Solution {
    public string LargestEven(string s)
    {
        for (int i = s.Length - 1; i >= 0; i--)
        {
            if (s[i] != '1')
                return s.Substring(0, i + 1);
        }

        return "";
    }
}