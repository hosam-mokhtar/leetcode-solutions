Link: https://leetcode.com/problems/find-if-digit-game-can-be-won/
Language: C#





public class Solution {
        public bool CanAliceWin(int[] nums)
        {
            int single_sum = 0;
            int double_sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < 10)
                    single_sum += nums[i];
                else
                    double_sum += nums[i];
            }
          return single_sum != double_sum ? true : false;
        }
}