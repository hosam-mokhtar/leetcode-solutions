Link: https://leetcode.com/problems/longest-uncommon-subsequence-i/
Language: C#







public class Solution {
        public int FindLUSlength(string a, string b)
        {
            return a == b ? -1 : a.Length > b.Length ? a.Length : b.Length;
        }
}