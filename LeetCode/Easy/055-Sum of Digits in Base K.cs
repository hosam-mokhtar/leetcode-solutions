Link: https://leetcode.com/problems/sum-of-digits-in-base-k/
Language: C#



public class Solution {
        public int SumBase(int n, int k)
        {
            int sum = 0;
            while (n>0)
            {
                sum += n % k;
                n/=k;
            }
            return sum;
        }
}