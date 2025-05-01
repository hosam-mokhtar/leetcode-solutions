Link: https://leetcode.com/problems/contains-duplicate-ii/
Language: C#






public class Solution {
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            Dictionary<int, int> result = new();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!result.TryAdd(nums[i], i))
                {
                    if (Math.Abs(result[nums[i]] - i) <= k)
                        return true;
                    else
                        result[nums[i]] = i;
                }
            }
            return false;
        }
}