Link: https://leetcode.com/problems/jewels-and-stones/
Language: C#





public class Solution {
        public int NumJewelsInStones(string jewels, string stones)
        {
            int counter = 0;
            for (int i = 0; i < stones.Length; i++)
            {
                if (jewels.Contains(stones[i]))
                    counter++;
            }
            return counter;
        }
}