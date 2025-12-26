Link: https://leetcode.com/problems/apple-redistribution-into-boxes/
Language: C#







public class Solution {
        public int MinimumBoxes(int[] apple, int[] capacity)
        {
            int sum = 0;

            for (int i = 0; i < apple.Length; i++)
            {
                sum += apple[i];
            }

            int[] freq = new int[51];

            for (int i = 0; i < capacity.Length; i++)
            {
                freq[capacity[i]]++;
            }

            int c = capacity.Length;

            for (int i = freq.Length - 1; i >= 1; i--)
            {
                while (freq[i] > 0)
                {
                    sum -= i;
                    c--;
                    if (sum < 1)
                        return capacity.Length - c;
                    freq[i]--;
                }
            }

            return 1;
        }
}