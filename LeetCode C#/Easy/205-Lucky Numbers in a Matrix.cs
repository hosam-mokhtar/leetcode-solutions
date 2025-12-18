Link: https://leetcode.com/problems/lucky-numbers-in-a-matrix/
Language: C#







public class Solution {
        public IList<int> LuckyNumbers(int[][] matrix)
        {
            List<int> luckyNumbers = [];

            for (int i = 0; i < matrix.Length; i++)
            {
                int minInRow = int.MaxValue;
                int indexCol = 0;

                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (minInRow > matrix[i][j])
                    {
                        minInRow = matrix[i][j];
                        indexCol = j;
                    }
                }

                bool isFlag = true;

                for (int k = 0; k < matrix.Length; k++)
                {
                    if (minInRow < matrix[k][indexCol])
                    {
                        isFlag = false;
                        break;
                    }
                }

                if (isFlag)
                    luckyNumbers.Add(minInRow);
            }

            return luckyNumbers;
        }
}