Link: https://leetcode.com/problems/three-divisors/
Language: C#




public class Solution {
        public bool IsThree(int n)
        {
            if (n < 4) return false;
            int counter = 0;           
                for (int i = 1; i*i<= n; i++)
                {
                    if (n % i == 0)
                    {
                        counter++;
                        if (n / i != i)
                        {
                            counter++;
                        }               
                        if (counter > 3) return false;
                    }
                }
            return counter==3;
        }
}