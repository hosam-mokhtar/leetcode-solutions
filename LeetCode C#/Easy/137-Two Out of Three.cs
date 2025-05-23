Link: https://leetcode.com/problems/two-out-of-three/
Language: C#






public class Solution {
        public IList<int> TwoOutOfThree(int[] nums1, int[] nums2, int[] nums3)
        {
            int[] freq = new int[101];
            int[] freq2 = new int[101];
            int[] freq3 = new int[101];

            for (int i = 0; i < freq.Length; i++)
            {
                if (i < nums1.Length)
                    freq[nums1[i]]++;
                if (i < nums2.Length)
                     freq2[nums2[i]]++;
                if (i < nums3.Length)
                     freq3[nums3[i]]++;
            }

            List<int> list = [];

            for (int i = 1; i < freq.Length; i++)
            {
                if (freq[i] > 0 && freq2[i] > 0
                    || freq[i] > 0 && freq3[i] > 0
                    || freq2[i] > 0 && freq3[i] > 0)
                {
                    list.Add(i);
                }
            }

            return list;
        }
}