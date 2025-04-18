Link: https://leetcode.com/problems/available-captures-for-rook/
Language: C#





public class Solution {
        public int NumRookCaptures(char[][] board)
        {
            int counter = 0;
            string rows = "";
            string cols = "";
            byte row = 0, col = 0;
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board.Length; j++)
                {
                    if (board[i][j] == 'R')
                    {
                        row = (byte)i;
                        col = (byte)j;
                    }
                }
            }
            for (int i = 0; i < board.Length; i++)
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