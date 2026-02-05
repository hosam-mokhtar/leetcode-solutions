Link: https://leetcode.com/problems/set-mismatch/
Language: C#







public class Solution {
        public int[] FindErrorNums(int[] nums)
        {
            Span<int> freq = stackalloc int[nums.Length + 1];
            int[] res = new int[2];

            for (int i = 0; i < nums.Length; i++)
            {
                freq[nums[i]]++;
            }
            for (int i = 1; i < freq.Length; i++)
            {
                if (freq[i] > 1)
                    res[0] = i;
                else if (freq[i] == 0)
                    res[1] = i;
                if (res[0] > 0 && res[1] > 0)
                    break;  
            }

            return res;
        }
}