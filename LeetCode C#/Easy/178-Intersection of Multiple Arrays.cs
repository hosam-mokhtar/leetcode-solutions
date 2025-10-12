Link: https://leetcode.com/problems/intersection-of-multiple-arrays/
Language: C#







public class Solution {
        public IList<int> Intersection(int[][] nums)
        {
            int[] freq = new int[1001];
            var list = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums[i].Length; j++)
                {
                    freq[nums[i][j]]++;
                }
            }

            for (int i = 0; i < freq.Length; i++)
            {
                if (freq[i] == nums.Length)
                    list.Add(i);
            }

            return list;
        }
}