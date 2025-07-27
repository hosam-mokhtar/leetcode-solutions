Link: https://leetcode.com/problems/count-hills-and-valleys-in-an-array/
Language: C#







public class Solution {
        public int CountHillValley(int[] nums)
        {
            int counter = 0;
            int temp = 0;
            List<int> list = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != temp)
                {
                    list.Add(nums[i]);
                    temp = nums[i];
                }
            }
            
            for (int i = 1; i < list.Count - 1; i++)
            {
                if ((list[i] > list[i - 1] && list[i] > list[i + 1]) ||
                    (list[i] < list[i - 1] && list[i] < list[i + 1]))
                    counter++;
            }

            return counter;
        }
}