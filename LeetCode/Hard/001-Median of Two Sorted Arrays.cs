Link: https://leetcode.com/problems/counting-words-with-a-given-prefix/
Language: C#






public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
      double[] mergearray = new double[nums1.Length + nums2.Length];

for (int i = 0; i  mergearray.Length; i++)
{
    if (nums1.Length  i)
    {
        mergearray[i] = nums1[i];
    }
    else
    {
        mergearray[i] = nums2[i - nums1.Length];
    }
}
Array.Sort(mergearray);
if (mergearray.Length % 2 == 0)
    return(mergearray[mergearray.Length  2] + mergearray[mergearray.Length  2 - 1])  /  2;
else
    return mergearray[(mergearray.Length  2)];
    }
}