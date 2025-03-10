Link: https://leetcode.com/problems/intersection-of-two-arrays-ii/
Language: C#




public class Solution {
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            int[] freq = new int[1001];
            var ans = new List<int>();
            for (int i = 0; i < nums1.Length; i++)
            {
                freq[nums1[i]]++;
            }
            for (int i = 0; i < nums2.Length; i++)
            {
                if (freq[nums2[i]]>0)
                {
                    ans.Add(nums2[i]);
                    freq[nums2[i]]--;
                }
            }
            return ans.ToArray();
        }
}