Link: https://leetcode.com/problems/account-balance-after-rounded-purchase/
Language: C#








public class Solution {
        public int AccountBalanceAfterPurchase(int purchaseAmount)
        {
            int n = purchaseAmount % 10;

            if (n < 5)
                return 100 - (purchaseAmount - n);
            else
                return 100 - (purchaseAmount + 10 - n);
        }
}