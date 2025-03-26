Link: https://leetcode.com/problems/xor-operation-in-an-array/
Language: C#





public class Solution {
public int XorOperation(int n, int start)
        {
            int result = 0;
            for (int i = 0;i <n; i++)
            {
                  result ^= start + 2 * i;
            }
             return result;
        }
}