Link: https://leetcode.com/problems/find-missing-elements/
Language: C#







public class Solution {
        public IList<int> FindMissingElements(int[] nums)
        {
            bool[] freq = new bool[101];
            int min = int.MaxValue;
            int max = int.MinValue;

            for (int i = 0; i < nums.Length; i++)
            {
                freq[nums[i]] = true;

                if (nums[i] < min)
                    min = nums[i];
                if (nums[i] > max)
                    max = nums[i];
            }

            var res = new List<int>();
 
            for (int i = min + 1; i < max; i++)
            {
                if (!freq[i])
                    res.Add(i);
            }

            return res;
        }
}