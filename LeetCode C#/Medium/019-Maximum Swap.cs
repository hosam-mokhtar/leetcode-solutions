Link: https://leetcode.com/problems/maximum-swap/
Language: C#






public class Solution {
        public int MaximumSwap(int num)
        {
            char[] chars = num.ToString().ToCharArray();
            int maxNum = num;

            for (int i = 0; i < chars.Length; i++)
            {
                for (int j = 0; j < chars.Length; j++)
                {
                    (chars[i], chars[j]) = (chars[j], chars[i]);

                    int x = int.Parse(new string(chars));

                    if (x > maxNum)
                        maxNum = x;

                    (chars[i], chars[j]) = (chars[j], chars[i]);
                }
            }
            return maxNum;
        }
}