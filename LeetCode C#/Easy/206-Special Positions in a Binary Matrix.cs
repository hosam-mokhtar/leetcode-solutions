Link: https://leetcode.com/problems/special-positions-in-a-binary-matrix/
Language: C#






public class Solution {
        public int NumSpecial(int[][] mat)
        {
            int numOfSpecialPosition = 0;
            int[] rows = new int[mat.Length];
            int[] cols = new int[mat[0].Length];

            for (int i = 0; i < mat.Length; i++)
            {
                for (int j = 0; j < mat[0].Length; j++)
                {
                    if (mat[i][j] == 1)
                    {
                        rows[i]++;
                        cols[j]++;
                    }
                }
            }

            for (int i = 0; i < mat.Length; i++)
            {
                if (rows[i] != 1) 
                    continue;
                for (int j = 0; j < mat[0].Length; j++)
                {
                    if (cols[j] == 1 && mat[i][j] == 1)
                    {
                        numOfSpecialPosition++;
                        break;
                    }
                }
            }

            return numOfSpecialPosition;
        }
}