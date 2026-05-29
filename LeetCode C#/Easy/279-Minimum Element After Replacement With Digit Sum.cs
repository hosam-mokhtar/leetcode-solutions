Link: https://leetcode.com/problems/minimum-element-after-replacement-with-digit-sum/
Language: C#







public class Solution {
        public int MinElement(int[] nums)
        {
            int min = int.MaxValue;

            foreach (var i in nums)
            {
                int n = i;
                int sum = 0;

                while (n > 0)
                {
                    sum += n % 10;
                    n /= 10;
                }
                if (sum < min)
                    min = sum;
            }
            
            return min;
        }
}