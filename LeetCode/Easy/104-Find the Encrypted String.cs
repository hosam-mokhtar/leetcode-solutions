Link: https://leetcode.com/problems/find-the-encrypted-string/
Language: C#






public class Solution {
        public string GetEncryptedString(string s, int k)
        {
            if (k == s.Length) return s;
            if (s.Length < k)
                k = k % s.Length;
            string front = s.Substring(0, k);
            string back = s.Substring(k);
            return back + front;
        }
}