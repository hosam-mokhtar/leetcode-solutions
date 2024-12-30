Link: https://leetcode.com/problems/palindrome-number/
Language: C#







public class Solution {
        public bool IsPalindrome(int x)
{
    String s = x.ToString();
 
  for (int i = 0; i < s.Length / 2; i++)
  {
      if (s[i] != s[s.Length - i - 1])
      {
          return false;

      }
  }
  return true;
}
}