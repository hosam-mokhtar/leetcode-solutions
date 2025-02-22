Link: https://leetcode.com/problems/subtract-the-product-and-sum-of-digits-of-an-integer/
Language: C#



public class Solution {
public int SubtractProductAndSum(int n) {
            int sum = 0;
            int product = 1;
                while (n > 0)
                {
                    sum += n % 10;
                    product *= n % 10;
                    n /= 10;
                }
            return product - sum;
        }
}