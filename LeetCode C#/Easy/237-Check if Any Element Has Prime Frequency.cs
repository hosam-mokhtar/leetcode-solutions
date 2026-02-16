Link: https://leetcode.com/problems/check-if-any-element-has-prime-frequency/
Language: C#








public class Solution {
        public bool CheckPrimeFrequency(int[] nums)
        {
            int[] freq = new int[101];

            for (int i = 0; i < nums.Length; i++)
            {
                freq[nums[i]]++;
            }

            for (int i = 0; i < freq.Length; i++)
            {
                bool isPrime = true;
                double sqrt = Math.Sqrt(freq[i]);

                for (int j = 2; j <= sqrt; j++)
                {
                    if (freq[i] % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime && freq[i] >= 2)
                    return true;
            }

            return false;
        }
}