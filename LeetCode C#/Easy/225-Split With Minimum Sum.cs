Link: https://leetcode.com/problems/split-with-minimum-sum/
Language: C#








public class Solution {
        public int SplitNum(int num)
        {
            int[]freq = new int[10];

            while (num > 0)
            {
                freq[num % 10]++;
                num /= 10;
            }

            var list = new List<int>();

            for (int i = 0; i < freq.Length; i++)
            {
                while (freq[i] > 0)
                {
                    list.Add(i);
                    freq[i]--;
                }
            }

            int sum = 0;
            int prod = 1;

            for (int i = list.Count - 1; i >= 0; i -= 2)
            {
                sum += prod * list[i];

                if (i - 1 >= 0)
                    sum += prod * list[i - 1];

                prod *= 10;
            }

            return sum;
        }
}