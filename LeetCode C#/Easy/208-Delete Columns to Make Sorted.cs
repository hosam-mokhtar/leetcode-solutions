Link: https://leetcode.com/problems/delete-columns-to-make-sorted/
Language: C#







public class Solution {
        public int MinDeletionSize(string[] strs)
        {
            int counter = 0;

            for (int c = 0; c < strs[0].Length; c++)
            {
                for (int r = 0; r < strs.Length - 1; r++)
                {
                    if (strs[r][c] > strs[r + 1][c])
                    {
                        counter++;
                        break;
                    }
                }
            }

            return counter;
        }
}