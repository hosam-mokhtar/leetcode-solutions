Link: https://leetcode.com/problems/merge-sorted-array/
Language: C#






public class Solution {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int[] newarr = new int[m + n];
            int i = newarr.Length;
            int mIndex = 0;
            int nIndex = 0;
            int c = 0;
            while (i > 0)
            {
                if (mIndex < m && nIndex < n)
                {
                    if (nums1[mIndex] < nums2[nIndex])
                    {
                        newarr[c] = nums1[mIndex];
                        mIndex++;
                    }
                    else
                    {
                        newarr[c] = nums2[nIndex];
                        nIndex++;
                    }
                }
                else if (mIndex < m)
                {
                    newarr[c] = nums1[mIndex];
                    mIndex++;
                }
                else if (nIndex < n)
                {
                    newarr[c] = nums2[nIndex];
                    nIndex++;
                }
                c++;
                i--;
            }
            for (int j = 0; j < newarr.Length; j++)
            {
                nums1[j] = newarr[j];
            }
        }
}