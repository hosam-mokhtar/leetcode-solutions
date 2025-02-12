Link: https://leetcode.com/problems/keyboard-row/
Language: C#



public class Solution {
public string[] FindWords(string[] words)
        {
            List<string> FindWords = new List<string>();
            int c1 = 0, c2 = 0, c3 = 0;
            int j = 0;
            for (int i = 0; i < words.Length; i++)
            {
                j=words[i].Length-1;
                while (j >= 0)
                {
                    if ("qwertyuiopQWERTYUIOP".IndexOf(words[i][j]) >= 0)
                    {
                        c1++;
                    }
                    else if ("asdfghjklASDFGHJKL".IndexOf(words[i][j]) >= 0)
                    {
                        c2++;
                    }
                    else if ("zxcvbnmZXCVBNM".IndexOf(words[i][j]) >= 0)
                    {
                        c3++;
                    }
                    j--;
                }
                if (words[i].Length == c1 || words[i].Length == c2 || words[i].Length == c3)
                {
                    FindWords.Add(words[i]);
                }
                c1 = 0;
                c2 = 0;
                c3 = 0;
            }
            return FindWords.ToArray();
        }
}