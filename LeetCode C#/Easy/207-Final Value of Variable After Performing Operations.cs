Link: https://leetcode.com/problems/final-value-of-variable-after-performing-operations/
Language: C#






public class Solution {
        public int FinalValueAfterOperations(string[] operations)
        {
            int X = 0;

            foreach (string operation in operations)
            {
                X += operation[1] == '+' ? 1 : -1;
            }

            return X;
        }
}