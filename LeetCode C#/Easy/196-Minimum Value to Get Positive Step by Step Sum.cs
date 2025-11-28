Link: https://leetcode.com/problems/minimum-value-to-get-positive-step-by-step-sum/
Language: C#






public class Solution {
        public int MinStartValue(int[] nums)
        {
            if (nums.Length == 1)
            {
                if (nums[0] >= 0)
                    return nums[0] + 1;
                else
                    return nums[0] * -1 + 1;
            }

            int minStartValue = 1;

            while (true)
            {
                int temp = minStartValue;
                bool isFlag = true;

                for (int i = 0; i < nums.Length; i++)
                {
                    temp += nums[i];

                    if (temp < 1)
                    {
                        isFlag = false;
                        minStartValue++;
                        break;
                    }
                }

                if (isFlag)
                    return minStartValue;
            }
        }
}