Link: https://leetcode.com/problems/find-greatest-common-divisor-of-array/
Language: C#





public class Solution {
        public int FindGCD(int[] nums)
        {
            int max = 1;
            int min = int.MaxValue;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > max)
                    max = nums[i];
                if (nums[i] < min)
                    min = nums[i];
            }
            if(max==min)return min;
            int gcd = 1;
            for (int i = 1; i <= min; i++)
            {
                if (min % i == 0 && max % i == 0)
                    gcd = i;
            }
            return gcd;
        }
}