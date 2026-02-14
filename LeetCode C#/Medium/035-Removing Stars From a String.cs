Link: https://leetcode.com/problems/removing-stars-from-a-string/
Language: C#








public class Solution {
        public string RemoveStars(string s)
        {
            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '*')
                    stack.Pop();
                else
                    stack.Push(s[i]);
            }

            return new string(stack.Reverse().ToArray());
        }
}