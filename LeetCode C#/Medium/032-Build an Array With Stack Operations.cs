Link: https://leetcode.com/problems/build-an-array-with-stack-operations/
Language: C#







public class Solution {
        public IList<string> BuildArray(int[] target, int n)
        {
            List<string> result = [];
            int c = 1;

            for (int i = 0; i < target.Length; i++)
            {
                result.Add("Push");
                
                while (target[i] > c)
                {
                    result.Add("Pop");
                    result.Add("Push");
                    c++;
                }
                
                c++;
            }

            return result;
        }
}