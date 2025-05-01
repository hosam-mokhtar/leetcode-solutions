Link: https://leetcode.com/problems/prime-in-diagonal/
Language: C#





public class Solution {
        public int DiagonalPrime(int[][] nums)
        {
            int maxPrime = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (maxPrime < nums[i][i])
                {
                    if (Isprime(nums[i][i]))
                        maxPrime = nums[i][i];
                }
                if (i != nums.Length - 1 - i)
                {
                    if (maxPrime < nums[i][nums.Length - 1 - i])
                    {
                        if (Isprime(nums[i][nums.Length - 1 - i]))
                            maxPrime = nums[i][nums.Length - 1 - i];
                    }
                }
            }
            return maxPrime;
        }
        public bool Isprime(int n)
        {   if(n<2) return false;
            double sqrtNumber=Math.Sqrt(n);
            for (int i = 2; i <=sqrtNumber; i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
}