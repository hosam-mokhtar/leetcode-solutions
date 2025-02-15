Link: https://leetcode.com/problems/merge-strings-alternately/
Language: C#




public class Solution {
public string MergeAlternately(string word1, string word2)
        {
            StringBuilder sb = new StringBuilder();
            for (int i=0;i<word1.Length+word2.Length;i++) {
                if (word1.Length > i)
                {
                    sb.Append(word1[i]);
                }
                if (word2.Length > i)
                {
                    sb.Append(word2[i]);
                }       
            }
            return sb.ToString();
        }
}