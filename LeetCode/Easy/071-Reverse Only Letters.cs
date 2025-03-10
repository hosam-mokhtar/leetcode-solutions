Link: https://leetcode.com/problems/reverse-only-letters/
Language: C#





public class Solution {
        public string ReverseOnlyLetters(string s)
        {   StringBuilder sb = new StringBuilder();
            char[] chars = s.ToCharArray();
            int left = 0;
            int right = chars.Length-1;
            while (left < right)
            {
                if (!Char.IsLetter(chars[left]))
                    left++;
                if (!Char.IsLetter(chars[right]))
                    right--;
                if (Char.IsLetter(chars[left]))
                {
                    if (Char.IsLetter(chars[right]))
                    {
                        (chars[left], chars[right]) = (chars[right], chars[left]);
                        left++;
                        right--;
                    }
                }
            }
            return new string (chars);
        }
}