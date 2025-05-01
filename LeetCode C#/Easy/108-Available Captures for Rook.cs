Link: https://leetcode.com/problems/available-captures-for-rook/
Language: C#





public class Solution {
        public int NumRookCaptures(char[][] board)
        {
            int counter = 0;
            string rows = "";
            string cols = "";
            int row = -1, col = -1;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (board[i][j] == 'R')
                    {
                        row = i;
                        col = j;
                        break;
                    }
                }
                if (row != -1) break;
            }
            for (int i = 0; i < 8; i++)
            {
                if (board[row][i] != '.')
                {
                    cols += board[row][i];
                }
                if ( board[i][col] != '.')
                {
                    rows += board[i][col];
                }
            }
            if (rows.Contains("Rp"))
                counter++;
            if (rows.Contains("pR"))
                counter++;
            if (cols.Contains("Rp"))
                counter++;
            if (cols.Contains("pR"))
                counter++;

            return counter;
        }
}