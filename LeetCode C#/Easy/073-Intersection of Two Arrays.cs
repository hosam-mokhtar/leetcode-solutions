Link: https://leetcode.com/problems/intersection-of-two-arrays/
Language: C#





public class Solution {
        public int[] Intersection(int[] nums1, int[] nums2)
        {  
           List<int> list = new ();
            int[]freq = new int[1001];
            for(int i = 0; i < nums1.Length; i++)
            {
                freq[nums1[i]] = 1;
            }
            for (int i = 0; i < nums2.Length; i++)
            {
                if (freq[nums2[i]] == 1)
                {
                    list.Add(nums2[i]);
                    freq[nums2[i]] = 0;
                }
            }
            return list.ToArray();
            /* HashSet<int> n1 = new HashSet<int>(nums1);
               HashSet<int> n2 = new HashSet<int>(nums2);
               var res =n1.Intersect(n2);
               return res.ToArray(); */
        }
}