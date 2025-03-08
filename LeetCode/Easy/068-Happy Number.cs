Link: https://leetcode.com/problems/happy-number/
Language: C#




public class Solution {
        public bool IsHappy(int n)
        {
            int temp = n;
            // Any unhappy number will eventually fall into the cycle (4 → 16 → 37 → 58 → 89 → 145 → 42 → 20 → 4)
            while (temp > 1 && temp!=4)
            {
                int sum = 0;
                while (temp > 0)
                {
                    sum+= (temp % 10)*(temp % 10);
                    temp /= 10;
                }
                    temp = sum;
            }
            return temp==1;
        }
}