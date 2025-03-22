Link: https://leetcode.com/problems/two-sum/
Language: C#




public class Solution {
       public int[] TwoSum(int[] nums, int target)
       {
           Dictionary<int, int> dict = [];
           dict[nums[0]] = 0;
           for (var i = 1; i < nums.Length; i++)
           {
               var b = target - nums[i];
               if (dict.TryGetValue(b, out int value)) return [value, i];
               dict[nums[i]] = i;
           }
           return [0];
           }
}
