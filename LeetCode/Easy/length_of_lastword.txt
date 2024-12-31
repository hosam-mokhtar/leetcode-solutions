Link: https://leetcode.com/problems/length-of-last-word/
Language: C#





public class Solution {
    public int LengthOfLastWord(string s) {
        int counter = 0;
        char c = ' ';
        c.ToString();
        for (int i=s.Length-1;-1<i;i--)
        {

            if (s[i] != c)
            { counter++;
                if (i==0 || s[i - 1] == c)
                    break; 
            }

        }
        return counter;     
                                          }
}