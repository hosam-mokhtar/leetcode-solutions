Link: https://leetcode.com/problems/restore-finishing-order/
Language: C#






public class Solution {
        public int[] RecoverOrder(int[] order, int[] friends)
        {
            int[] result = new int[friends.Length];
            int index = 0;

            for (int i = 0; i < order.Length; i++)
            {
                if (friends.Contains(order[i]))
                {
                    result[index] = order[i];
                    index++;
                }
            }

            return result;
        }
}