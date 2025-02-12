Link: https://leetcode.com/problems/longest-common-prefix/
Language: C#





public class Solution {
        public string LongestCommonPrefix(string[] strs)
   {
       StringBuilder sb = new StringBuilder();
       Array.Sort(strs);
       string first= strs[0];
       string last = strs[strs.Length - 1];    
       for(int i = 0; i < Math.Min(first.Length, last.Length);i++)
       {
           if (first[i] != last[i])
               return sb.ToString();
           else
               sb.Append(first[i]);
       }
       return sb.ToString();
   }
}