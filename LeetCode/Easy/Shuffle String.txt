Link: https://leetcode.com/problems/shuffle-string/
Language: C#



public class Solution {
public string RestoreString(string s, int[] indices)
        {    
             //Using StringBuilder
             //OR 
            char[] chars = new char[indices.Length];
            for (int i = 0; i < indices.Length; i++) {
                chars[indices[i]] = s[i];
            }
                return new string(chars);
        }
}