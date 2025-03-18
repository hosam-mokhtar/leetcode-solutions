Link: https://leetcode.com/problems/two-sum/
Language: C#




public class Solution {  
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dict = new ();
            for (int i = 0; i < nums.Length; i++)
            {
                int a = nums[i];
                int b = target - a;
                if (dict.ContainsKey(b))
                    {
                        return [dict[b],i];
                    }
                if (!dict.ContainsKey(a))
                    dict.Add(a, i);
            }
            return [0];
        }
}
