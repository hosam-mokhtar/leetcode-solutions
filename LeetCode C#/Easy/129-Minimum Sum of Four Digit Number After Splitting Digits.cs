Link: https://leetcode.com/problems/minimum-sum-of-four-digit-number-after-splitting-digits/
Language: C#






public class Solution {
        public int MinimumSum(int num)
        {
            int[] n = new int[]{
                                 num / 1000,
                                 num / 100 % 10,
                                 num / 10 % 10,
                                 num % 10
                               };
            int min1 = int.MaxValue;
            int min2 = int.MaxValue;
            int max1 = int.MinValue;
            int max2 = int.MinValue;

            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] < min1)
                {
                    min2 = min1;
                    min1 = n[i];

                }
                else if (n[i] < min2)
                    min2 = n[i];

                if (n[i] > max1)
                {
                    max2 = max1;
                    max1 = n[i];
                }
                else if (n[i] > max2)
                    max2 = n[i];
            }

            return (min1 * 10 + max1) + (min2 * 10 + max2);
        }
}