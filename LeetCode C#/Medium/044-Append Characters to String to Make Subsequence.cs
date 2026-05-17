Link: https://leetcode.com/problems/append-characters-to-string-to-make-subsequence/
Language: C#






public class Solution
{
    public int AppendCharacters(string s, string t)
    {
        int j = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (j < t.Length)
            {
                if (t[j] == s[i])
                    j++;
            }
            else
                break;
        }

        return t.Length - j;
    }
}