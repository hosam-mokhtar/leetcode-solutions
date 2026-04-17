Link: https://leetcode.com/problems/find-the-degree-of-each-vertex/
Language: C#







public class Solution {
        public int[] FindDegrees(int[][] matrix)
        {
            int[] res = new int[matrix.Length];

            for (int i = 0; i < matrix.Length; i++)
            {
                int sum = 0;

                foreach (var j in matrix[i])
                    sum += j;
                
                res[i] = sum;
            }
            
            return res;
        }
}