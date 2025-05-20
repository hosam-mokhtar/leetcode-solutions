Link: https://leetcode.com/problems/count-elements-with-maximum-frequency/
Language: C#







public class Solution {
        public int MaxFrequencyElements(int[] nums)
        {
            byte counter = 0;
            byte maxfrequency = 0;
            byte[] freq = new byte[101];

            for (int i = 0; i < nums.Length; i++)
            {
                freq[nums[i]]++;

                if (freq[nums[i]] > maxfrequency)
                    maxfrequency = freq[nums[i]];
            }

            foreach (int i in freq)
            {
                if (i == maxfrequency)
                    counter++;
            }

            return counter*maxfrequency;
        }
}