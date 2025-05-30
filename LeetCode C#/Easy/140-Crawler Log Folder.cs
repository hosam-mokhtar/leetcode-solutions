Link: https://leetcode.com/problems/crawler-log-folder/
Language: C#






public class Solution {
        public int MinOperations(string[] logs)
        {
            Stack<string> stack = [];
            
            foreach (string s in logs)
            {
                if (s == "../")
                {
                    if(stack.Any())
                       stack.Pop();
                }
                else if(s != "./")
                    stack.Push(s);
            }

            return stack.Count;
        }
}