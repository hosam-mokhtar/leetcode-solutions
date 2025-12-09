Link: https://leetcode.com/problems/first-letter-to-appear-twice/
Language: C#







public class Solution {
    public char RepeatedCharacter(string s)
    {
        List<char> list = new List<char>();

        for (int i = 0; i < s.Length; i++)
        {
            if (list.Contains(s[i]))
                return s[i];

            list.Add(s[i]);
        }

        return '\0';
    }
}