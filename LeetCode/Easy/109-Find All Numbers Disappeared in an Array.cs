Link: https://leetcode.com/problems/find-all-numbers-disappeared-in-an-array/
Language: C#






public class Solution {
        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            List<int> list = [];
            bool[] freq = new bool[nums.Length + 1];
            for (int i = 0; i < nums.Length; i++)
            {
                freq[nums[i]] = true;
            }
            for (int i = 1; i < freq.Length; i++)
            {
                if (freq[i] == false)
                    list.Add(i);
            }
            return list;
        }
}