Link: https://leetcode.com/problems/minimum-capacity-box/
Language: C#









public class Solution {
        public int MinimumIndex(int[] capacity, int itemSize)
        {
            int min = int.MaxValue;
            int index = -1;

            for (int i = 0; i < capacity.Length; i++)
            {
                if (capacity[i] == itemSize)
                    return i;
                if (capacity[i] > itemSize && min > capacity[i])
                {
                    min = capacity[i];
                    index = i;
                }
            }

            return index;
        }
}